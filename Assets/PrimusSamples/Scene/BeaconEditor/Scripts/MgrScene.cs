using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Primus.Core.Singleton;
using Primus.Toolbox.Beacon;
using Primus.Toolbox.UI;
using Primus.Toolbox.Scene;
using PrimusSamples.BeaconEditor.Beacon;
using PrimusSamples.BeaconEditor.Canvas;
using PrimusSamples.Main;

namespace PrimusSamples.BeaconEditor
{
    /// <summary>
    /// Map Editor Program's main function. It creates and manupilates all the instances in the program. 
    /// </summary>
    public partial class MgrScene
        : BaseMonoSingleton<MgrScene>
        , IMgrScene<SceneType, Input>
    {
        // Public, Serialized, and Internal //
        public Beacon.Bibliotheca Bibliotheca;
        [SerializeField] private MgrBackgroundQuad _backgroundQuad;
        [field: SerializeField] public MgrCamera CameraManager { get; private set; }
        [field: SerializeField] public MgrCanvas CanvasManager { get; private set; }
        [field: SerializeField] public MgrCursor CursorManager { get; private set; }

        // Set just bigger than half the radius of cylinder prefab.
        [SerializeField] private float _neighborBeaconDistanceLowerLimit = 25.0f;
        [SerializeField] private float _neighborBeaconDistanceEpsilon = 0.01f;
        public BeaconType BeaconTypeSelectedDropdown { get; set; }
        // List of all the beacons in scene.
        [SerializeField] internal List<GameObject> BeaconInstances;
        public bool CanAddBeacon { get; internal set; }
        public bool CanSelectedBeaconMove { get; internal set; }

        // Private, and Protected //
        protected bool _areFunctionalitiesActive;
        private bool _isMainCameraActive;

        // Coupled with indNeighborBeaconsInPosition().
        private List<GameObject> _neighborBeaconInstancesCache;
        // Coupled with indNeighborBeaconsInPosition().
        private List<float> _neighborBeaconInstancesDistanceCache;
        // Instance cache for new beacon checkouts, is set to null when not in use.
        private GameObject _beaconInstanceCache;
        private GameObject _selectedBeaconInstance = null;

        private Vector3 _selectionOffsetCache;
        [Header("Layers")] [SerializeField] private LayerMask _layerBackground;
        [SerializeField] private LayerMask _layerBeacon;

        protected override void Awake()
        {
            base.Awake();

            BeaconInstances = new List<GameObject>();
            _neighborBeaconInstancesCache = new List<GameObject>();
            _neighborBeaconInstancesDistanceCache = new List<float>();
            _areFunctionalitiesActive = false;
            CanSelectedBeaconMove = false;
        }

        private void Start()
        {
            if (Bibliotheca == null) { throw new System.MissingMemberException("Bibliotheca"); }
            if (CameraManager == null) { throw new System.MissingMemberException("CameraManager"); }
            if (CanvasManager == null) { throw new System.MissingMemberException("CanvasManager"); }
            if (CursorManager == null) { throw new System.MissingMemberException("CursorManager"); }
            if (_backgroundQuad == null) { throw new System.MissingMemberException("BackgroundQuad"); }

            CursorManager.CameraManager = CameraManager;

            if (Instance == this) InitialLoadNextScene();
        }

        private void Update()
        {
            DragSelectedBeacon();
        }

        private void SwitchCamera()
        {
            // Switch camera index from 0 to 1 or vice-versa.
            CameraManager.IndexActive = CameraManager.IndexActive == 0 ? 1 : 0;
        }

        private void MoveCamera(Vector2 delta)
        {
            Vector2 moveCache = delta * CameraManager.MoveMultiplier;
            CameraManager.Move(moveCache.x, moveCache.y);
            CameraManager.ActiveCamera.transform.position =
                _backgroundQuad.Clamp(CameraManager.ActiveCamera.transform.position);
        }

        private GameObject FindNearestBeaconWithinRadiusAtPosition(float radius, Vector3 position, GameObject exceptBeaconInstance = null)
        {
            FindNeighborBeaconsWithinRadiusAtPosition(radius, position, exceptBeaconInstance);

            if (0 < _neighborBeaconInstancesCache.Count & _neighborBeaconInstancesDistanceCache.Count == _neighborBeaconInstancesCache.Count)
            {
                int leastDistant = 0;
                float leastDistance = _neighborBeaconInstancesDistanceCache[0];
                for (int index = 1; index < _neighborBeaconInstancesDistanceCache.Count; index++)
                {
                    if (_neighborBeaconInstancesDistanceCache[index] < leastDistance)
                    {
                        leastDistance = _neighborBeaconInstancesDistanceCache[index];
                        leastDistant = index;
                    }
                }

                return _neighborBeaconInstancesCache[leastDistant];
            }
            return null;
        }

        private void FindNeighborBeaconsWithinRadiusAtPosition(float radius, Vector3 position, GameObject referenceBeaconInstance)
        {
            _neighborBeaconInstancesCache.Clear();
            _neighborBeaconInstancesDistanceCache.Clear();

            foreach (var beaconInstance in BeaconInstances)
            {
                if (beaconInstance == referenceBeaconInstance)
                {
                    continue;
                }

                float distance = (position - beaconInstance.transform.position).magnitude;
                if (distance < radius)
                {
                    _neighborBeaconInstancesCache.Add(beaconInstance);
                    _neighborBeaconInstancesDistanceCache.Add(distance);
                }
            }
        }

        private void SelectBeacon()
        {
            var quadruple = CursorManager.GetHit(_layerBackground);
            // If there was UI hit
            if (quadruple.Item4)
            {
                _selectedBeaconInstance = null;
                return;
            }
            // If there was no Beacon hit
            if (quadruple.Item1.x == Mathf.Infinity) { return; }
            _selectedBeaconInstance = FindNearestBeaconWithinRadiusAtPosition(
                _neighborBeaconDistanceLowerLimit / 2.0f + _neighborBeaconDistanceEpsilon,
                quadruple.Item1
            );
            if (_selectedBeaconInstance)
            {
                _selectionOffsetCache = quadruple.Item1 - _selectedBeaconInstance.transform.position;
            }
        }

        private void DeleteSelectedBeacon()
        {
            if (_selectedBeaconInstance)
            {
                BeaconInstances.Remove(_selectedBeaconInstance);
                Bibliotheca.CheckIn(_selectedBeaconInstance.GetComponent<BaseBeacon<BeaconType>>());
                _selectedBeaconInstance = null;
                OnSelectedBeaconChanged();
                OnBeaconInstancesChanged();
            }
        }

        private void DragSelectedBeacon()
        {
            if (_selectedBeaconInstance && CanSelectedBeaconMove)
            {
                Vector3 coordinates = CursorManager.GetCoordinates(_layerBackground);
                if (coordinates.x == Mathf.Infinity) { return; }

                coordinates.y = 0;
                var neighbor = FindNearestBeaconWithinRadiusAtPosition(_neighborBeaconDistanceLowerLimit, coordinates, _selectedBeaconInstance);
                if (!neighbor)
                {
                    _selectedBeaconInstance.transform.position = coordinates;
                }
            }
        }

        private void AddBeacon()
        {
            if (CanAddBeacon)
            {
                Vector3 coordinates = CursorManager.GetCoordinates(_layerBackground);
                // Height is standardized to zero
                coordinates.y = 0;

                // If there were no hit.
                if (coordinates.x == Mathf.Infinity)
                {
                    return;
                }
                // If there exists a selection candidate instead.
                if (FindNearestBeaconWithinRadiusAtPosition(_neighborBeaconDistanceLowerLimit / 2.0f + _neighborBeaconDistanceEpsilon, coordinates))
                {
                    return;
                }

                _beaconInstanceCache = Bibliotheca.CheckOut(BeaconTypeSelectedDropdown);
                if (_beaconInstanceCache)
                {
                    _beaconInstanceCache.transform.position = coordinates;
                    EnlistBeaconInstance(_beaconInstanceCache);

                    // Keep cache empty when not in use.
                    _beaconInstanceCache = null;

                    OnBeaconInstancesChanged();
                }
            }
        }

        internal void EnlistBeaconInstance(GameObject beaconInstance)
        {
            if (beaconInstance)
            {
                BeaconInstances.Add(beaconInstance);
            }
            else
            {
                Debug.Log("Beacon instance is null!");
            }
        }

        public void ClearBeacons()
        {
            foreach (var beaconInstance in BeaconInstances)
            {
                Bibliotheca.CheckIn(beaconInstance.GetComponent<BaseBeacon<BeaconType>>());
            }

            BeaconInstances.Clear();
        }

        private void ToggleEscMenu()
        {
            CanvasManager.PanelEscMenu.gameObject.SetActive(!CanvasManager.PanelEscMenu.gameObject.activeSelf);
            CanvasManager.PanelListBeacon.gameObject.SetActive(!CanvasManager.PanelListBeacon.gameObject.activeSelf);
        }

        private void OnSelectedBeaconChanged()
        {
            CanvasManager.PanelSelectionBeacon.BeaconInstance = _selectedBeaconInstance;
        }

        public void OnBeaconInstancesChanged()
        {
            CanvasManager.ClearAndPopulateListButtonBeacon();
        }

        internal void SaveState()
        {
            IO.StateIO.Write();
        }

        internal void LoadState()
        {
            IO.StateIO.Read("Save01.bin");
            foreach (var beaconInstance in BeaconInstances)
            {
                BeaconType type = beaconInstance.GetComponent<BaseBeacon<BeaconType>>().BiblionTitle;
            }
        }

        private void ZoomCameraLinear(float value)
        {
            if (CameraManager.ActiveCamera.orthographic)
            {
                CameraManager.ZoomLinearOrthographic(value, 200, 4000);
            }
            else
            {
                CameraManager.ZoomLinearPerspective(value, 0, 400000);
            }
        }

        private void ZoomCameraExponential(float value)
        {
            float zoomMultiplierExponential = 1.02f;
            int contextQuant = 120;

            // value represents scaleFactor within if statement.
            // Sets scale factor to specified ratio for zoom-in, or inverse of it for zoom-out.
            if (value < 0)
            {
                value = -value;
                value = Mathf.Pow(zoomMultiplierExponential, ((int)value / contextQuant));
                value = 1 / value;
            }
            else
            {
                value = Mathf.Pow(zoomMultiplierExponential, ((int)value / contextQuant));
            }

            if (CameraManager.ActiveCamera.orthographic)
            {
                CameraManager.ZoomExponentialOrthographic(value);
            }
            else
            {
                CameraManager.ZoomExponentialPerspective(value);
            }
        }


        public void InitialLoadNextScene()
        {
            Main.MgrScene.Instance.InitialLoadNextScene();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        internal void OnBeaconSelect(InputAction.CallbackContext context)
        {
            SelectBeacon();
        }

        internal void OnUpdatePanelBeaconSelection(InputAction.CallbackContext context)
        {
            OnSelectedBeaconChanged();
        }

        internal void OnBeaconDelete(InputAction.CallbackContext context)
        {
            DeleteSelectedBeacon();
        }

        internal void OnBeaconAdd(InputAction.CallbackContext context)
        {
            AddBeacon();
        }

        internal void OnToggleEscMenu(InputAction.CallbackContext context)
        {
            ToggleEscMenu();
        }

        internal void OnToggleActive(InputAction.CallbackContext context)
        {
            _areFunctionalitiesActive = !_areFunctionalitiesActive;
        }

        public void OnCameraManagerSwitch(InputAction.CallbackContext context)
        {
            SwitchCamera();
        }

        public void OnCameraManagerMove(InputAction.CallbackContext context)
        {
            MoveCamera(context.ReadValue<Vector2>());
        }

        public void OnCameraManagerZoom(InputAction.CallbackContext context)
        {
            // Returns multiples of positive/negative 120.0f
            ZoomCameraLinear(context.ReadValue<float>());
        }
    }
}
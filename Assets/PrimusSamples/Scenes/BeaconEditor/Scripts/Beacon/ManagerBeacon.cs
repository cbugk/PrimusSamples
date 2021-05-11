using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Primus.Toolbox.Beacon;
using Primus.Toolbox.Service;
using PrimusSamples.BeaconEditor.Service;
using PrimusSamples.BeaconEditor.View;

namespace PrimusSamples.BeaconEditor.Beacon
{
    public class ManagerBeacon : MonoBehaviour
    {
        // Public, Serialized, and Internal //
        [field: SerializeField] public OfficerCanvas CanvasManager { get; private set; }
        [SerializeField] private float _neighborBcnDistanceLimitMax = 25.0f;
        [SerializeField] private float _neighborBcnDistanceEpsilon = 0.01f;
        public TypeBcn BeaconTypeSelectedDropdown { get; set; }
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

        private void Awake()
        {
            BeaconInstances = new List<GameObject>();
            _neighborBeaconInstancesCache = new List<GameObject>();
            _neighborBeaconInstancesDistanceCache = new List<float>();
            _areFunctionalitiesActive = false;
            CanSelectedBeaconMove = false;
        }

        private void Start()
        {
        }

        private void Update()
        {
            DragSelectedBeacon();
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
            var quadruple = YellowPages.Instance.MngrView.OfficerCursor.GetHit(_layerBackground);
            // If there was UI hit
            if (quadruple.Item4)
            {
                _selectedBeaconInstance = null;
                return;
            }
            // If there was no Beacon hit
            if (quadruple.Item1.x == Mathf.Infinity) { return; }
            _selectedBeaconInstance = FindNearestBeaconWithinRadiusAtPosition(
                _neighborBcnDistanceLimitMax / 2.0f + _neighborBcnDistanceEpsilon,
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
                YellowPages.Instance.Bibliotheca.CheckIn(_selectedBeaconInstance.GetComponent<BaseBeacon<TypeBcn>>());
                _selectedBeaconInstance = null;
                OnSelectedBeaconChanged();
                OnBeaconInstancesChanged();
            }
        }

        private void DragSelectedBeacon()
        {
            if (_selectedBeaconInstance && CanSelectedBeaconMove)
            {
                Vector3 coordinates = YellowPages.Instance.MngrView.OfficerCursor.GetCoordinates(_layerBackground);
                if (coordinates.x == Mathf.Infinity) { return; }

                coordinates.y = 0;
                var neighbor = FindNearestBeaconWithinRadiusAtPosition(_neighborBcnDistanceLimitMax, coordinates, _selectedBeaconInstance);
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
                Vector3 coordinates = YellowPages.Instance.MngrView.OfficerCursor.GetCoordinates(_layerBackground);
                // Height is standardized to zero
                coordinates.y = 0;

                // If there were no hit.
                if (coordinates.x == Mathf.Infinity)
                {
                    return;
                }
                // If there exists a selection candidate instead.
                if (FindNearestBeaconWithinRadiusAtPosition(_neighborBcnDistanceLimitMax / 2.0f + _neighborBcnDistanceEpsilon, coordinates))
                {
                    return;
                }

                _beaconInstanceCache = YellowPages.Instance.Bibliotheca.CheckOut(BeaconTypeSelectedDropdown);
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
                YellowPages.Instance.Bibliotheca.CheckIn(beaconInstance.GetComponent<BaseBeacon<TypeBcn>>());
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
            IO.MgrIO.Write();
        }

        internal void LoadState()
        {
            IO.MgrIO.Read("Save01.bin");
            foreach (var beaconInstance in BeaconInstances)
            {
                TypeBcn type = beaconInstance.GetComponent<BaseBeacon<TypeBcn>>().BiblionTitle;
            }
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
    }
}
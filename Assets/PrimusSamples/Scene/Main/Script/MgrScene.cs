using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Primus.Core.Singleton;
using Primus.Toolbox.UI;
using Primus.Toolbox.Scene;
using PrimusSamples.BeaconEditor;
using PrimusSamples.BiblionShowcase;
using PrimusSamples.BibliothecaSample;

namespace PrimusSamples.Main
{

    public class MgrScene
        : BaseMonoSingleton<MgrScene>
        , IMgrSceneMain<SceneType, Input>
    {
        // Motto of the Scene Manager: "Think like an immortal, bam!".

        // Public, internal, and/or Serialized.
        public bool HasInitialized { get; private set; }
        [SerializeField] protected readonly SceneType SelfSceneType;
        [field: SerializeField] public MgrCursor CursorManager { get; private set; }
        [field: SerializeField] public MgrCamera CameraManager { get; private set; }
        public SceneType ActiveSceneType { get; private set; }
        public int NumberOfScenes { get; private set; }

        // Private and/or protected

        protected override void Awake()
        {
            base.Awake();

            HasInitialized = false;

            NumberOfScenes = Enum.GetValues(typeof(SceneType)).Length;
            ActiveSceneType = SelfSceneType;
        }

        private void Start()
        {
            if (CursorManager == null || CameraManager == null)
            {
                throw new System.MissingMemberException();
            }

            HasInitialized = true;

            // Chain-loading every scene.
            // Runs for the first singleton created only.
            if (Instance == this) InitialLoadNextScene();
        }

        public void InitialLoadNextScene()
        {
            int buildIndex = SceneManager.GetActiveScene().buildIndex;

            int nextIndex = -1;
            // If not the last, increment.
            if (buildIndex + 1 < NumberOfScenes)
            {
                nextIndex = buildIndex + 1;
            }
            // If the last, wrap back to start.
            else if ((buildIndex + 1) == NumberOfScenes)
            {
                nextIndex = 0;
            }

            // Redundant check to be safe.
            if (-1 < nextIndex)
            {
                Debug.Log($"current: {buildIndex}, {ActiveSceneType}; next: {nextIndex}, {IntToSceneType(nextIndex)}");

                // Disable current manager unless Main
                if (IntToSceneType(buildIndex) != SceneType.MAIN)//SelfSceneType)
                {
                    SetManagerActive(IntToSceneType(buildIndex), false);
                }

                ActiveSceneType = IntToSceneType(nextIndex);
                SceneManager.LoadScene(nextIndex, LoadSceneMode.Single);
            }
        }

        public void SwitchTo(SceneType sceneType)
        {
            // If same scene, do not act.
            if (Enum.Equals(sceneType, ActiveSceneType))
            {
                return;
            }

            // Disable current manager unless Main
            if (!Enum.Equals(SelfSceneType, ActiveSceneType))
            {
                SetManagerActive(ActiveSceneType, false);
            }

            // Enable back current manager.
            SetManagerActive(sceneType, true);

            ActiveSceneType = sceneType;
            SceneManager.LoadScene(SceneTypeToInt(sceneType), LoadSceneMode.Single);
        }

        protected bool ValidateIndex(int index)
        {
            if (0 <= index || index < NumberOfScenes)
            {
                return true;
            }

            return false;
        }

        public void SetManagerActive(SceneType type, bool value)
        {
            switch (type)
            {
                case SceneType.MAIN:
                    Main.MgrScene.Instance.gameObject.SetActive(value);
                    break;
                case SceneType.BEACON_EDITOR:
                    BeaconEditor.MgrScene.Instance.gameObject.SetActive(value);
                    break;
                case SceneType.BIBLION_SHOWCASE:
                    BiblionShowcase.MgrScene.Instance.gameObject.SetActive(value);
                    break;
                case SceneType.BIBLIOTHECA_SAMPLE:
                    BibliothecaSample.MgrScene.Instance.gameObject.SetActive(value);
                    break;
            }
        }

        public int SceneTypeToInt(SceneType sceneType) => (int)sceneType;

        public SceneType IntToSceneType(int sceneIndex) => (SceneType)sceneIndex;

        public void OnCameraManagerMove(InputAction.CallbackContext context)
        {
            MoveCamera(context.ReadValue<Vector2>());
        }

        private void MoveCamera(Vector2 delta)
        {
            Vector2 moveCache = delta * CameraManager.MoveMultiplier;
            CameraManager.Move(moveCache.x, moveCache.y);
        }

        public void OnCameraManagerZoom(InputAction.CallbackContext context)
        {
            // Returns multiples of positive/negative 120.0f
            ZoomCameraLinear(context.ReadValue<float>());
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
    }
}
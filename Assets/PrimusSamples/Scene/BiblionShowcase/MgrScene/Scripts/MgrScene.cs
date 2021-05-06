using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Primus.Core.Singleton;
using Primus.Toolbox.UI;
using Primus.Toolbox.Scene;
using PrimusSamples.Main;

namespace PrimusSamples.BiblionShowcase
{
    public class MgrScene
        : BaseMonoSingleton<MgrScene>
        , IMgrScene<SceneType, Input>
    {
        [field: SerializeField] public MgrCursor CursorManager { get; private set; }
        [field: SerializeField] public MgrCamera CameraManager { get; private set; }

        protected override void Awake()
        {
            base.Awake();
        }

        private void Start()
        {
            // Chain-loading every scene.
            // Runs for the first singleton created only.
            if (Instance == this) InitialLoadNextScene();
        }


        public void InitialLoadNextScene()
        {
            Main.MgrScene.Instance.InitialLoadNextScene();
        }

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
            Debug.LogWarning("zoom zoom zoom");
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

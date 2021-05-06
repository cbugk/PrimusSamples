using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Core.Singleton;
using Primus.Toolbox.Input;

namespace PrimusSamples.Main
{
    public class MgrInput
        : BaseMonoSingleton<MgrInput>
        , IMgrInput<SceneType, Input, MgrScene>
    {
        public Input InputActions { get; private set; }

        protected override void Awake()
        {
            base.Awake();

            InputActions = new Input();
        }

        private void OnEnable()
        {
            if (MgrScene.Instance == null)
            {
                Debug.LogWarning("Main.MgrScene instance null.");
            }

            InputActions.SceneMain.MgrScene_SwitchTo_MAIN.Enable();
            InputActions.SceneMain.MgrScene_SwitchTo_MAIN.performed += ctx => MgrScene.Instance.SwitchTo(SceneType.MAIN);

            InputActions.SceneMain.MgrScene_SwitchTo_BEACON_EDITOR.Disable();
            InputActions.SceneMain.MgrScene_SwitchTo_BEACON_EDITOR.performed += ctx => MgrScene.Instance.SwitchTo(SceneType.BEACON_EDITOR);

            InputActions.SceneMain.MgrScene_SwitchTo_BIBLION_SHOWCASE.Enable();
            InputActions.SceneMain.MgrScene_SwitchTo_BIBLION_SHOWCASE.performed += ctx => MgrScene.Instance.SwitchTo(SceneType.BIBLION_SHOWCASE);

            InputActions.SceneMain.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.Enable();
            InputActions.SceneMain.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.performed += ctx => MgrScene.Instance.SwitchTo(SceneType.BIBLIOTHECA_SAMPLE);

            InputActions.Shared.MgrCamera_Zoom.Enable();
            InputActions.Shared.MgrCamera_Zoom.performed += MgrScene.Instance.OnCameraManagerZoom;

            InputActions.Shared.MgrCamera_UnlockMove.Enable();
            InputActions.Shared.MgrCamera_UnlockMove.performed += ctx => MgrScene.Instance.CameraManager.CanCameraMove = true;
            InputActions.Shared.MgrCamera_UnlockMove.canceled += ctx => MgrScene.Instance.CameraManager.CanCameraMove = false;

            InputActions.Shared.MgrCamera_Move.Enable();
            InputActions.Shared.MgrCamera_Move.performed += MgrScene.Instance.OnCameraManagerMove;
        }

        private void OnDisable()
        {
            if (Instance == this)
            {
                InputActions.SceneMain.MgrScene_SwitchTo_MAIN.Disable();
                InputActions.SceneMain.MgrScene_SwitchTo_MAIN.performed -= ctx => MgrScene.Instance.SwitchTo(SceneType.MAIN);

                InputActions.SceneMain.MgrScene_SwitchTo_BEACON_EDITOR.Disable();
                InputActions.SceneMain.MgrScene_SwitchTo_BEACON_EDITOR.performed -= ctx => MgrScene.Instance.SwitchTo(SceneType.BEACON_EDITOR);

                InputActions.SceneMain.MgrScene_SwitchTo_BIBLION_SHOWCASE.Disable();
                InputActions.SceneMain.MgrScene_SwitchTo_BIBLION_SHOWCASE.performed -= ctx => MgrScene.Instance.SwitchTo(SceneType.BIBLION_SHOWCASE);

                InputActions.SceneMain.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.Disable();
                InputActions.SceneMain.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.performed -= ctx => MgrScene.Instance.SwitchTo(SceneType.BIBLIOTHECA_SAMPLE);

                InputActions.Shared.MgrCamera_Zoom.Disable();
                InputActions.Shared.MgrCamera_Zoom.performed -= MgrScene.Instance.OnCameraManagerZoom;

                InputActions.Shared.MgrCamera_UnlockMove.Disable();
                InputActions.Shared.MgrCamera_UnlockMove.performed -= ctx => MgrScene.Instance.CameraManager.CanCameraMove = true;
                InputActions.Shared.MgrCamera_UnlockMove.canceled -= ctx => MgrScene.Instance.CameraManager.CanCameraMove = false;

                InputActions.Shared.MgrCamera_Move.Disable();
                InputActions.Shared.MgrCamera_Move.performed -= MgrScene.Instance.OnCameraManagerMove;
            }
        }
    }
}
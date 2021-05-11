using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Core.Singleton;
using Primus.Toolbox.Input;

namespace PrimusSamples.Init.Service
{
    public class ProcessInputMain
        : BaseMonoSingleton<ProcessInputMain>
        , IDaemonInput<SceneType, ProcessSceneMain>
    {

        protected override void Awake()
        {
            base.Awake();
        }

        private void Start()
        {
            OnSceneActivated();
        }

        private void ValidateFields()
        {
            if (BrokerControls.Instance == null) { throw new System.MissingMemberException($"{name}: BrokerControls."); }
            if (ProcessSceneMain.Instance == null) { throw new System.MissingMemberException($"{name}: ProcessSceneMain is null."); }
        }

        public void OnSceneActivated()
        {
            ValidateFields();
        }

        private void OnEnable()
        {
            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_MAIN.Enable();
            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_MAIN.performed += ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.INIT);

            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BEACON_EDITOR.Disable();
            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BEACON_EDITOR.performed += ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.BEACON_EDITOR);

            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLION_SHOWCASE.Enable();
            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLION_SHOWCASE.performed += ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.BIBLION_SHOWCASE);

            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.Enable();
            YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.performed += ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.BIBLIOTHECA_SAMPLE);
        }
        // private void OnEnable()
        // {
        //     YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.Enable();
        //     YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.performed += ctx => BrokerControls.Instance.OnCameraZoom(ctx);

        //     YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.Enable();
        //     YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.performed += ctx => BrokerControls.Instance.OnUnLockCameraMove(true);
        //     YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.canceled += ctx => BrokerControls.Instance.OnUnLockCameraMove(false);

        //     YellowPages.Instance.InputActions.Shared.OfcCamera_Move.Enable();
        //     YellowPages.Instance.InputActions.Shared.OfcCamera_Move.performed += ctx => BrokerControls.Instance.OnCameraMove(ctx);
        // }

        private void OnDisable()
        {
            if (Instance == this)
            {
                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_MAIN.Disable();
                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_MAIN.performed -= ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.INIT);

                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BEACON_EDITOR.Disable();
                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BEACON_EDITOR.performed -= ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.BEACON_EDITOR);

                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLION_SHOWCASE.Disable();
                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLION_SHOWCASE.performed -= ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.BIBLION_SHOWCASE);

                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.Disable();
                YellowPages.Instance.InputActions.SceneInit.MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.performed -= ctx => ProcessSceneMain.Instance.SwitchTo(SceneType.BIBLIOTHECA_SAMPLE);
            }

            // private void OnDisable()
            // {
            //     YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.Disable();
            //     YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.performed -= ctx => BrokerControls.Instance.OnCameraZoom(ctx);

            //     YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.Disable();
            //     YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.performed -= ctx => BrokerControls.Instance.OnUnLockCameraMove(true);
            //     YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.canceled -= ctx => BrokerControls.Instance.OnUnLockCameraMove(false);

            //     YellowPages.Instance.InputActions.Shared.OfcCamera_Move.Disable();
            //     YellowPages.Instance.InputActions.Shared.OfcCamera_Move.performed -= ctx => BrokerControls.Instance.OnCameraMove(ctx);
            // }
        }
    }
}
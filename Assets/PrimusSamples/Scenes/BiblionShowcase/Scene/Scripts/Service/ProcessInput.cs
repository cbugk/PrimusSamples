using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Toolbox.Input;
using PrimusSamples.Init;

namespace PrimusSamples.BiblionShowcase.Service
{
    public class ProcessInput
        : MonoBehaviour
        , IDaemonInput<SceneType, ProcessScene>
    {
                private BrokerControls _brokerControls;

        private void Start()
        {
            OnSceneActivated();
        }

        private void ValidateFields()
        {
            if (_brokerControls == null) { throw new System.MissingMemberException($"{name}: BrokerControls."); }
        }

        public void OnSceneActivated()
        {
            _brokerControls = FindObjectOfType<BrokerControls>();

            ValidateFields();
        }

        private void OnEnable()
        {
            YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.Enable();
            YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.performed += ctx => _brokerControls.OnCameraZoom(ctx);

            YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.Enable();
            YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.performed += ctx => _brokerControls.OnUnLockCameraMove(true);
            YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.canceled += ctx => _brokerControls.OnUnLockCameraMove(false);

            YellowPages.Instance.InputActions.Shared.OfcCamera_Move.Enable();
            YellowPages.Instance.InputActions.Shared.OfcCamera_Move.performed += ctx => _brokerControls.OnCameraMove(ctx);
        }

        private void OnDisable()
        {
            YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.Disable();
            YellowPages.Instance.InputActions.Shared.OfcCamera_Zoom.performed -= ctx => _brokerControls.OnCameraZoom(ctx);

            YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.Disable();
            YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.performed -= ctx => _brokerControls.OnUnLockCameraMove(true);
            YellowPages.Instance.InputActions.Shared.OfcCamera_UnlockMove.canceled -= ctx => _brokerControls.OnUnLockCameraMove(false);

            YellowPages.Instance.InputActions.Shared.OfcCamera_Move.Disable();
            YellowPages.Instance.InputActions.Shared.OfcCamera_Move.performed -= ctx => _brokerControls.OnCameraMove(ctx);
        }
    }
}

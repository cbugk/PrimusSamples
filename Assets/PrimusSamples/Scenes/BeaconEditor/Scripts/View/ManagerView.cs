using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Primus.Toolbox.View;
using PrimusSamples.BeaconEditor.Service;

namespace PrimusSamples.BeaconEditor.View
{
    public class ManagerView : BaseManagerView
    {
        public OfficerCanvas OfcCanvas { get; private set; }

        protected override void OnSceneActivated()
        {
            base.OnSceneActivated();
            OfcCanvas = GetComponentInChildren<OfficerCanvas>();
        }

        protected override void ValidateFields()
        {
            base.ValidateFields();
            if (OfcCanvas == null) { throw new System.MissingMemberException("CanvasManager"); }
        }

        private void SwitchCamera()
        {
            // Switch camera index from 0 to 1 or vice-versa.
            OfficerCamera.IndexActive = OfficerCamera.IndexActive == 0 ? 1 : 0;
        }

        public override void MoveCamera(Vector2 delta)
        {
            base.MoveCamera(delta);
            OfficerCamera.ActiveCamera.transform.position =
                YellowPages.Instance.Bckgrnd.Clamp(OfficerCamera.ActiveCamera.transform.position);
        }

        public void OnCameraManagerSwitch(InputAction.CallbackContext context)
        {
            SwitchCamera();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrimusSamples;
using Primus.Toolbox.Input;
using PrimusSamples.BeaconEditor;
using PrimusSamples.Main;

namespace PrimusSamples.BeaconEditor
{
    public class MgrInput
        : MonoBehaviour
        , IMgrInput<SceneType, Input, MgrScene>
    {

        public Input InputActions { get => Main.MgrInput.Instance.InputActions; }

        // private void Awake()
        // {
        //     InputActions = new Input();
        // }

        private void OnEnable()
        {
            InputActions.SceneBeaconEditor.MgrScene_ToggleActive.Enable();
            InputActions.SceneBeaconEditor.MgrScene_ToggleActive.performed += MgrScene.Instance.OnToggleActive;

            InputActions.Shared.Bcn_Delete.Enable();
            InputActions.Shared.Bcn_Delete.performed += MgrScene.Instance.OnBeaconDelete;

            InputActions.Shared.Bcn_UnlockAdd.Enable();
            InputActions.Shared.Bcn_UnlockAdd.started += ctx => MgrScene.Instance.CanAddBeacon = true;
            InputActions.Shared.Bcn_UnlockAdd.canceled += ctx => MgrScene.Instance.CanAddBeacon = false;

            InputActions.Shared.Bcn_Add.Enable();
            InputActions.Shared.Bcn_Add.started += MgrScene.Instance.OnBeaconAdd;

            InputActions.Shared.Bcn_MoveLock.Enable();
            InputActions.Shared.Bcn_MoveLock.started += ctx => MgrScene.Instance.CanSelectedBeaconMove = true;
            InputActions.Shared.Bcn_MoveLock.canceled += ctx => MgrScene.Instance.CanSelectedBeaconMove = false;

            // Beacon.Select must reside upon Canvas.UpdatePanelBeaconSelection
            // for update to take place immenently rather than in next click.
            InputActions.Shared.Bcn_Select.Enable();
            InputActions.Shared.Bcn_Select.started += MgrScene.Instance.OnBeaconSelect;
            // Do not seperate block.
            InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.Enable();
            InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.performed += MgrScene.Instance.OnUpdatePanelBeaconSelection;

            InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.Enable();
            InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.performed += MgrScene.Instance.OnToggleEscMenu;

            InputActions.Shared.MgrCamera_SwitchTo_Toggle.Enable();
            InputActions.Shared.MgrCamera_SwitchTo_Toggle.performed += MgrScene.Instance.OnCameraManagerSwitch;

            InputActions.Shared.MgrCamera_Zoom.Enable();
            InputActions.Shared.MgrCamera_Zoom.performed += ctx => Debug.Log("asdZoom");
            InputActions.Shared.MgrCamera_Zoom.performed += MgrScene.Instance.OnCameraManagerZoom;

            InputActions.Shared.MgrCamera_UnlockMove.Enable();
            InputActions.Shared.MgrCamera_UnlockMove.performed += ctx => MgrScene.Instance.CameraManager.CanCameraMove = true;
            InputActions.Shared.MgrCamera_UnlockMove.canceled += ctx => MgrScene.Instance.CameraManager.CanCameraMove = false;

            InputActions.Shared.MgrCamera_Move.Enable();
            InputActions.Shared.MgrCamera_Move.performed += MgrScene.Instance.OnCameraManagerMove;
        }

        private void OnDisable()
        {
            InputActions.SceneBeaconEditor.MgrScene_ToggleActive.Disable();
            InputActions.SceneBeaconEditor.MgrScene_ToggleActive.performed -= MgrScene.Instance.OnToggleActive;

            InputActions.Shared.Bcn_Delete.Disable();
            InputActions.Shared.Bcn_Delete.performed -= MgrScene.Instance.OnBeaconDelete;

            InputActions.Shared.Bcn_UnlockAdd.Disable();
            InputActions.Shared.Bcn_UnlockAdd.started -= ctx => MgrScene.Instance.CanAddBeacon = true;
            InputActions.Shared.Bcn_UnlockAdd.canceled -= ctx => MgrScene.Instance.CanAddBeacon = false;

            InputActions.Shared.Bcn_Add.Disable();
            InputActions.Shared.Bcn_Add.started -= MgrScene.Instance.OnBeaconAdd;

            InputActions.Shared.Bcn_MoveLock.Disable();
            InputActions.Shared.Bcn_MoveLock.started -= ctx => MgrScene.Instance.CanSelectedBeaconMove = true;
            InputActions.Shared.Bcn_MoveLock.canceled -= ctx => MgrScene.Instance.CanSelectedBeaconMove = false;

            // See comment at Enable counterpart.
            InputActions.Shared.Bcn_Select.Disable();
            InputActions.Shared.Bcn_Select.started -= MgrScene.Instance.OnBeaconSelect;
            // Do not seperate block.
            InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.Disable();
            InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.performed -= MgrScene.Instance.OnUpdatePanelBeaconSelection;

            InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.Disable();
            InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.performed -= MgrScene.Instance.OnToggleEscMenu;

            InputActions.Shared.MgrCamera_SwitchTo_Toggle.Disable();
            InputActions.Shared.MgrCamera_SwitchTo_Toggle.performed -= MgrScene.Instance.OnCameraManagerSwitch;

            InputActions.Shared.MgrCamera_Zoom.Disable();
            InputActions.Shared.MgrCamera_Zoom.performed -= ctx => Debug.Log("asdZoom");
            InputActions.Shared.MgrCamera_Zoom.performed -= MgrScene.Instance.OnCameraManagerZoom;

            InputActions.Shared.MgrCamera_UnlockMove.Disable();
            InputActions.Shared.MgrCamera_UnlockMove.performed -= ctx => MgrScene.Instance.CameraManager.CanCameraMove = true;
            InputActions.Shared.MgrCamera_UnlockMove.canceled -= ctx => MgrScene.Instance.CameraManager.CanCameraMove = false;

            InputActions.Shared.MgrCamera_Move.Disable();
            InputActions.Shared.MgrCamera_Move.performed -= MgrScene.Instance.OnCameraManagerMove;
        }
    }
}
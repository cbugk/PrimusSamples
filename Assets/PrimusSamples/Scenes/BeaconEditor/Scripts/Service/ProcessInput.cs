using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrimusSamples;
using Primus.Toolbox.Input;
using PrimusSamples.BeaconEditor;
using PrimusSamples.Init;

namespace PrimusSamples.BeaconEditor.Service
{
    public class ProcessInput
        : MonoBehaviour
        , IDaemonInput<SceneType, ProcessSceneInit>
    {
        // private void Awake()
        // {
        //     InputActions = new Input();
        // }

        /*
                private void OnEnable()
                {

                    InputActions.SceneBeaconEditor.MgrScene_ToggleActive.Enable();
                    InputActions.SceneBeaconEditor.MgrScene_ToggleActive.performed += ProcessScene.Instance.OnToggleActive;

                    InputActions.Shared.Bcn_Delete.Enable();
                    InputActions.Shared.Bcn_Delete.performed += ProcessScene.Instance.OnBeaconDelete;

                    InputActions.Shared.Bcn_UnlockAdd.Enable();
                    InputActions.Shared.Bcn_UnlockAdd.started += ctx => ProcessScene.Instance.CanAddBeacon = true;
                    InputActions.Shared.Bcn_UnlockAdd.canceled += ctx => ProcessScene.Instance.CanAddBeacon = false;

                    InputActions.Shared.Bcn_Add.Enable();
                    InputActions.Shared.Bcn_Add.started += ProcessScene.Instance.OnBeaconAdd;

                    InputActions.Shared.Bcn_MoveLock.Enable();
                    InputActions.Shared.Bcn_MoveLock.started += ctx => ProcessScene.Instance.CanSelectedBeaconMove = true;
                    InputActions.Shared.Bcn_MoveLock.canceled += ctx => ProcessScene.Instance.CanSelectedBeaconMove = false;

                    // Beacon.Select must reside upon Canvas.UpdatePanelBeaconSelection
                    // for update to take place immenently rather than in next click.
                    InputActions.Shared.Bcn_Select.Enable();
                    InputActions.Shared.Bcn_Select.started += ProcessScene.Instance.OnBeaconSelect;
                    // Do not seperate block.
                    InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.Enable();
                    InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.performed += ProcessScene.Instance.OnUpdatePanelBeaconSelection;

                    InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.Enable();
                    InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.performed += ProcessScene.Instance.OnToggleEscMenu;

                    InputActions.Shared.OfcCamera_SwitchTo_Toggle.Enable();
                    InputActions.Shared.OfcCamera_SwitchTo_Toggle.performed += ProcessScene.Instance.OnCameraManagerSwitch;

                    InputActions.Shared.OfcCamera_Zoom.Enable();
                    InputActions.Shared.OfcCamera_Zoom.performed += ctx => Debug.Log("asdZoom");
                    InputActions.Shared.OfcCamera_Zoom.performed += ProcessScene.Instance.OnCameraManagerZoom;

                    InputActions.Shared.OfcCamera_UnlockMove.Enable();
                    InputActions.Shared.OfcCamera_UnlockMove.performed += ctx => ProcessScene.Instance.OfcCamera.CanCameraMove = true;
                    InputActions.Shared.OfcCamera_UnlockMove.canceled += ctx => ProcessScene.Instance.OfcCamera.CanCameraMove = false;

                    InputActions.Shared.OfcCamera_Move.Enable();
                    InputActions.Shared.OfcCamera_Move.performed += ProcessScene.Instance.OnCameraManagerMove;
                }

                private void OnDisable()
                {
                    InputActions.SceneBeaconEditor.MgrScene_ToggleActive.Disable();
                    InputActions.SceneBeaconEditor.MgrScene_ToggleActive.performed -= ProcessScene.Instance.OnToggleActive;

                    InputActions.Shared.Bcn_Delete.Disable();
                    InputActions.Shared.Bcn_Delete.performed -= ProcessScene.Instance.OnBeaconDelete;

                    InputActions.Shared.Bcn_UnlockAdd.Disable();
                    InputActions.Shared.Bcn_UnlockAdd.started -= ctx => ProcessScene.Instance.CanAddBeacon = true;
                    InputActions.Shared.Bcn_UnlockAdd.canceled -= ctx => ProcessScene.Instance.CanAddBeacon = false;

                    InputActions.Shared.Bcn_Add.Disable();
                    InputActions.Shared.Bcn_Add.started -= ProcessScene.Instance.OnBeaconAdd;

                    InputActions.Shared.Bcn_MoveLock.Disable();
                    InputActions.Shared.Bcn_MoveLock.started -= ctx => ProcessScene.Instance.CanSelectedBeaconMove = true;
                    InputActions.Shared.Bcn_MoveLock.canceled -= ctx => ProcessScene.Instance.CanSelectedBeaconMove = false;

                    // See comment at Enable counterpart.
                    InputActions.Shared.Bcn_Select.Disable();
                    InputActions.Shared.Bcn_Select.started -= ProcessScene.Instance.OnBeaconSelect;
                    // Do not seperate block.
                    InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.Disable();
                    InputActions.SceneBeaconEditor.MgrCanvas_UpdatePanelBeaconSelection.performed -= ProcessScene.Instance.OnUpdatePanelBeaconSelection;

                    InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.Disable();
                    InputActions.SceneBeaconEditor.MgrCanvas_ToggleEscMenu.performed -= ProcessScene.Instance.OnToggleEscMenu;

                    InputActions.Shared.OfcCamera_SwitchTo_Toggle.Disable();
                    InputActions.Shared.OfcCamera_SwitchTo_Toggle.performed -= ProcessScene.Instance.OnCameraManagerSwitch;

                    InputActions.Shared.OfcCamera_Zoom.Disable();
                    InputActions.Shared.OfcCamera_Zoom.performed -= ctx => Debug.Log("asdZoom");
                    InputActions.Shared.OfcCamera_Zoom.performed -= ProcessScene.Instance.OnCameraManagerZoom;

                    InputActions.Shared.OfcCamera_UnlockMove.Disable();
                    InputActions.Shared.OfcCamera_UnlockMove.performed -= ctx => ProcessScene.Instance.OfcCamera.CanCameraMove = true;
                    InputActions.Shared.OfcCamera_UnlockMove.canceled -= ctx => ProcessScene.Instance.OfcCamera.CanCameraMove = false;

                    InputActions.Shared.OfcCamera_Move.Disable();
                    InputActions.Shared.OfcCamera_Move.performed -= ProcessScene.Instance.OnCameraManagerMove;
                }
        */
    }
}
// GENERATED AUTOMATICALLY FROM 'Assets/PrimusSamples/Shared/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PrimusSamples
{
    public class @Input : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Input()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""SceneMain"",
            ""id"": ""8c39651d-4c28-4c81-8083-d078e0c54557"",
            ""actions"": [
                {
                    ""name"": ""MgrScene_SwitchTo_MAIN"",
                    ""type"": ""Button"",
                    ""id"": ""6a4652cd-32df-49d4-a31c-26fed28b7292"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrScene_SwitchTo_BEACON_EDITOR"",
                    ""type"": ""Button"",
                    ""id"": ""c89b888c-9e93-4e10-9ae0-340e9925ba75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrScene_SwitchTo_BIBLION_SHOWCASE"",
                    ""type"": ""Button"",
                    ""id"": ""ffaff0fa-a3ac-45c8-9c57-ace9cbad57f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE"",
                    ""type"": ""Button"",
                    ""id"": ""ab970cc4-7b4f-4d5e-8eba-d384b6c6c917"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a17a053d-e306-406e-89d8-27bb142cea90"",
                    ""path"": ""<Keyboard>/f12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_SwitchTo_MAIN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3338f15e-a6db-47a8-87b6-85efbbbb4abe"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_SwitchTo_BEACON_EDITOR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""584e96c6-1595-4dcd-85b7-91ead4912516"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_SwitchTo_BIBLION_SHOWCASE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01cd0499-6189-416a-85bb-2d654c52669b"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SceneBeaconEditor"",
            ""id"": ""b76f15e3-dbf4-436e-8452-06912fe9c1a9"",
            ""actions"": [
                {
                    ""name"": ""MgrCanvas_ToggleEscMenu"",
                    ""type"": ""Button"",
                    ""id"": ""e28aba3e-051e-4989-87d0-ff37a6ff6d53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrCanvas_UpdatePanelBeaconSelection"",
                    ""type"": ""Button"",
                    ""id"": ""38e29fa7-eb2c-4188-a23f-18f4a80df4fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrScene_ToggleActive"",
                    ""type"": ""Button"",
                    ""id"": ""1c2d9f08-d7bb-4705-af50-339868963027"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce445044-2b94-4c41-b91c-3e5674f0f358"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCanvas_ToggleEscMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b0bbfc8-22be-4b72-b0a8-38357e0cef30"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCanvas_UpdatePanelBeaconSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""562f3387-ed24-4075-8742-c6ca2fb85a28"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_ToggleActive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""89caa0c0-f716-4dae-9e5b-939b67676e54"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_ToggleActive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""aaf4deff-9553-4dd0-9654-b065432af317"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrScene_ToggleActive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""SceneBiblionShowcase"",
            ""id"": ""bc4ff694-ad27-4574-a199-12c6970ffb8f"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""SceneBibliothecaEditor"",
            ""id"": ""31ea331c-59b7-4d33-a5d6-4faa808fd7fe"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""Shared"",
            ""id"": ""8e2e38dd-5e1e-4b9f-b77e-1b0065f7a795"",
            ""actions"": [
                {
                    ""name"": ""Bcn_MoveLock"",
                    ""type"": ""Button"",
                    ""id"": ""627dbc38-b0d4-441e-9d66-58c5f74a62e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bcn_UnlockAdd"",
                    ""type"": ""Button"",
                    ""id"": ""1a40f72d-76ae-4c44-b1b7-a86a67e68722"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bcn_Add"",
                    ""type"": ""Button"",
                    ""id"": ""67cd5fcd-435b-48c3-a836-43ae7049db7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bcn_Select"",
                    ""type"": ""Button"",
                    ""id"": ""53c7c9bf-2786-4b8c-9cb5-0ae1178d290e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Bcn_Delete"",
                    ""type"": ""Button"",
                    ""id"": ""50f9bf74-c09f-42ff-9f70-467e68d09653"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""MgrCamera_SwitchTo_Toggle"",
                    ""type"": ""Value"",
                    ""id"": ""189a9410-6c69-4fea-9d04-09be30428b24"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrCamera_Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""f1aa78e2-037c-4869-acf9-c87889c9b458"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrCamera_Move"",
                    ""type"": ""Value"",
                    ""id"": ""c5da0158-e8f3-4e54-a092-0c867504541c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MgrCamera_UnlockMove"",
                    ""type"": ""Button"",
                    ""id"": ""37cf96fb-6ac8-41a8-88a8-3c323e48ba32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ccf6730-f11c-4510-883c-e41e923b53fd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bcn_MoveLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a82c59ac-9569-4527-b7c6-56dde0924cad"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bcn_UnlockAdd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c276d053-d505-45cc-95e9-c7804b8f5168"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bcn_Add"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05d30694-6e71-4ccf-bcad-38d4d2ab4501"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bcn_Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1e8918f-d022-4f80-8b17-34843ae96e91"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bcn_Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bf26a29-e4b8-4589-90d7-e3c2b6dc006b"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bcn_Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With Two Modifiers"",
                    ""id"": ""b1991a8e-652d-4c6e-98cc-d6d2fdf8c36b"",
                    ""path"": ""ButtonWithTwoModifiers"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_SwitchTo_Toggle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier1"",
                    ""id"": ""a4100a29-3ee1-4b43-b61b-0836f292e201"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_SwitchTo_Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifier2"",
                    ""id"": ""608a8b62-8c15-4bc4-ae24-b2cc97805db8"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_SwitchTo_Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""33c3d457-74ff-4294-be80-621d296581f2"",
                    ""path"": ""<Keyboard>/OEM1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_SwitchTo_Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""a045141c-51aa-48e4-83c8-31b942111689"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""39873c1f-6d00-4dd0-9db1-14f66c05784a"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""90ccc76a-47a4-4c64-a68b-89ac1569af0f"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d7be0f16-21f7-44ec-bcc7-55824ff5e334"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57534f44-294b-4359-93df-65d5b07d4fed"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MgrCamera_UnlockMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // SceneMain
            m_SceneMain = asset.FindActionMap("SceneMain", throwIfNotFound: true);
            m_SceneMain_MgrScene_SwitchTo_MAIN = m_SceneMain.FindAction("MgrScene_SwitchTo_MAIN", throwIfNotFound: true);
            m_SceneMain_MgrScene_SwitchTo_BEACON_EDITOR = m_SceneMain.FindAction("MgrScene_SwitchTo_BEACON_EDITOR", throwIfNotFound: true);
            m_SceneMain_MgrScene_SwitchTo_BIBLION_SHOWCASE = m_SceneMain.FindAction("MgrScene_SwitchTo_BIBLION_SHOWCASE", throwIfNotFound: true);
            m_SceneMain_MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE = m_SceneMain.FindAction("MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE", throwIfNotFound: true);
            // SceneBeaconEditor
            m_SceneBeaconEditor = asset.FindActionMap("SceneBeaconEditor", throwIfNotFound: true);
            m_SceneBeaconEditor_MgrCanvas_ToggleEscMenu = m_SceneBeaconEditor.FindAction("MgrCanvas_ToggleEscMenu", throwIfNotFound: true);
            m_SceneBeaconEditor_MgrCanvas_UpdatePanelBeaconSelection = m_SceneBeaconEditor.FindAction("MgrCanvas_UpdatePanelBeaconSelection", throwIfNotFound: true);
            m_SceneBeaconEditor_MgrScene_ToggleActive = m_SceneBeaconEditor.FindAction("MgrScene_ToggleActive", throwIfNotFound: true);
            // SceneBiblionShowcase
            m_SceneBiblionShowcase = asset.FindActionMap("SceneBiblionShowcase", throwIfNotFound: true);
            // SceneBibliothecaEditor
            m_SceneBibliothecaEditor = asset.FindActionMap("SceneBibliothecaEditor", throwIfNotFound: true);
            // Shared
            m_Shared = asset.FindActionMap("Shared", throwIfNotFound: true);
            m_Shared_Bcn_MoveLock = m_Shared.FindAction("Bcn_MoveLock", throwIfNotFound: true);
            m_Shared_Bcn_UnlockAdd = m_Shared.FindAction("Bcn_UnlockAdd", throwIfNotFound: true);
            m_Shared_Bcn_Add = m_Shared.FindAction("Bcn_Add", throwIfNotFound: true);
            m_Shared_Bcn_Select = m_Shared.FindAction("Bcn_Select", throwIfNotFound: true);
            m_Shared_Bcn_Delete = m_Shared.FindAction("Bcn_Delete", throwIfNotFound: true);
            m_Shared_MgrCamera_SwitchTo_Toggle = m_Shared.FindAction("MgrCamera_SwitchTo_Toggle", throwIfNotFound: true);
            m_Shared_MgrCamera_Zoom = m_Shared.FindAction("MgrCamera_Zoom", throwIfNotFound: true);
            m_Shared_MgrCamera_Move = m_Shared.FindAction("MgrCamera_Move", throwIfNotFound: true);
            m_Shared_MgrCamera_UnlockMove = m_Shared.FindAction("MgrCamera_UnlockMove", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // SceneMain
        private readonly InputActionMap m_SceneMain;
        private ISceneMainActions m_SceneMainActionsCallbackInterface;
        private readonly InputAction m_SceneMain_MgrScene_SwitchTo_MAIN;
        private readonly InputAction m_SceneMain_MgrScene_SwitchTo_BEACON_EDITOR;
        private readonly InputAction m_SceneMain_MgrScene_SwitchTo_BIBLION_SHOWCASE;
        private readonly InputAction m_SceneMain_MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
        public struct SceneMainActions
        {
            private @Input m_Wrapper;
            public SceneMainActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @MgrScene_SwitchTo_MAIN => m_Wrapper.m_SceneMain_MgrScene_SwitchTo_MAIN;
            public InputAction @MgrScene_SwitchTo_BEACON_EDITOR => m_Wrapper.m_SceneMain_MgrScene_SwitchTo_BEACON_EDITOR;
            public InputAction @MgrScene_SwitchTo_BIBLION_SHOWCASE => m_Wrapper.m_SceneMain_MgrScene_SwitchTo_BIBLION_SHOWCASE;
            public InputAction @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE => m_Wrapper.m_SceneMain_MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
            public InputActionMap Get() { return m_Wrapper.m_SceneMain; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SceneMainActions set) { return set.Get(); }
            public void SetCallbacks(ISceneMainActions instance)
            {
                if (m_Wrapper.m_SceneMainActionsCallbackInterface != null)
                {
                    @MgrScene_SwitchTo_MAIN.started -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_MAIN;
                    @MgrScene_SwitchTo_MAIN.performed -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_MAIN;
                    @MgrScene_SwitchTo_MAIN.canceled -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_MAIN;
                    @MgrScene_SwitchTo_BEACON_EDITOR.started -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BEACON_EDITOR;
                    @MgrScene_SwitchTo_BEACON_EDITOR.performed -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BEACON_EDITOR;
                    @MgrScene_SwitchTo_BEACON_EDITOR.canceled -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BEACON_EDITOR;
                    @MgrScene_SwitchTo_BIBLION_SHOWCASE.started -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BIBLION_SHOWCASE;
                    @MgrScene_SwitchTo_BIBLION_SHOWCASE.performed -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BIBLION_SHOWCASE;
                    @MgrScene_SwitchTo_BIBLION_SHOWCASE.canceled -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BIBLION_SHOWCASE;
                    @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.started -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
                    @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.performed -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
                    @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.canceled -= m_Wrapper.m_SceneMainActionsCallbackInterface.OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
                }
                m_Wrapper.m_SceneMainActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MgrScene_SwitchTo_MAIN.started += instance.OnMgrScene_SwitchTo_MAIN;
                    @MgrScene_SwitchTo_MAIN.performed += instance.OnMgrScene_SwitchTo_MAIN;
                    @MgrScene_SwitchTo_MAIN.canceled += instance.OnMgrScene_SwitchTo_MAIN;
                    @MgrScene_SwitchTo_BEACON_EDITOR.started += instance.OnMgrScene_SwitchTo_BEACON_EDITOR;
                    @MgrScene_SwitchTo_BEACON_EDITOR.performed += instance.OnMgrScene_SwitchTo_BEACON_EDITOR;
                    @MgrScene_SwitchTo_BEACON_EDITOR.canceled += instance.OnMgrScene_SwitchTo_BEACON_EDITOR;
                    @MgrScene_SwitchTo_BIBLION_SHOWCASE.started += instance.OnMgrScene_SwitchTo_BIBLION_SHOWCASE;
                    @MgrScene_SwitchTo_BIBLION_SHOWCASE.performed += instance.OnMgrScene_SwitchTo_BIBLION_SHOWCASE;
                    @MgrScene_SwitchTo_BIBLION_SHOWCASE.canceled += instance.OnMgrScene_SwitchTo_BIBLION_SHOWCASE;
                    @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.started += instance.OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
                    @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.performed += instance.OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
                    @MgrScene_SwitchTo_BIBLIOTHECA_SAMPLE.canceled += instance.OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE;
                }
            }
        }
        public SceneMainActions @SceneMain => new SceneMainActions(this);

        // SceneBeaconEditor
        private readonly InputActionMap m_SceneBeaconEditor;
        private ISceneBeaconEditorActions m_SceneBeaconEditorActionsCallbackInterface;
        private readonly InputAction m_SceneBeaconEditor_MgrCanvas_ToggleEscMenu;
        private readonly InputAction m_SceneBeaconEditor_MgrCanvas_UpdatePanelBeaconSelection;
        private readonly InputAction m_SceneBeaconEditor_MgrScene_ToggleActive;
        public struct SceneBeaconEditorActions
        {
            private @Input m_Wrapper;
            public SceneBeaconEditorActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @MgrCanvas_ToggleEscMenu => m_Wrapper.m_SceneBeaconEditor_MgrCanvas_ToggleEscMenu;
            public InputAction @MgrCanvas_UpdatePanelBeaconSelection => m_Wrapper.m_SceneBeaconEditor_MgrCanvas_UpdatePanelBeaconSelection;
            public InputAction @MgrScene_ToggleActive => m_Wrapper.m_SceneBeaconEditor_MgrScene_ToggleActive;
            public InputActionMap Get() { return m_Wrapper.m_SceneBeaconEditor; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SceneBeaconEditorActions set) { return set.Get(); }
            public void SetCallbacks(ISceneBeaconEditorActions instance)
            {
                if (m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface != null)
                {
                    @MgrCanvas_ToggleEscMenu.started -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrCanvas_ToggleEscMenu;
                    @MgrCanvas_ToggleEscMenu.performed -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrCanvas_ToggleEscMenu;
                    @MgrCanvas_ToggleEscMenu.canceled -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrCanvas_ToggleEscMenu;
                    @MgrCanvas_UpdatePanelBeaconSelection.started -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrCanvas_UpdatePanelBeaconSelection;
                    @MgrCanvas_UpdatePanelBeaconSelection.performed -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrCanvas_UpdatePanelBeaconSelection;
                    @MgrCanvas_UpdatePanelBeaconSelection.canceled -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrCanvas_UpdatePanelBeaconSelection;
                    @MgrScene_ToggleActive.started -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrScene_ToggleActive;
                    @MgrScene_ToggleActive.performed -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrScene_ToggleActive;
                    @MgrScene_ToggleActive.canceled -= m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface.OnMgrScene_ToggleActive;
                }
                m_Wrapper.m_SceneBeaconEditorActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MgrCanvas_ToggleEscMenu.started += instance.OnMgrCanvas_ToggleEscMenu;
                    @MgrCanvas_ToggleEscMenu.performed += instance.OnMgrCanvas_ToggleEscMenu;
                    @MgrCanvas_ToggleEscMenu.canceled += instance.OnMgrCanvas_ToggleEscMenu;
                    @MgrCanvas_UpdatePanelBeaconSelection.started += instance.OnMgrCanvas_UpdatePanelBeaconSelection;
                    @MgrCanvas_UpdatePanelBeaconSelection.performed += instance.OnMgrCanvas_UpdatePanelBeaconSelection;
                    @MgrCanvas_UpdatePanelBeaconSelection.canceled += instance.OnMgrCanvas_UpdatePanelBeaconSelection;
                    @MgrScene_ToggleActive.started += instance.OnMgrScene_ToggleActive;
                    @MgrScene_ToggleActive.performed += instance.OnMgrScene_ToggleActive;
                    @MgrScene_ToggleActive.canceled += instance.OnMgrScene_ToggleActive;
                }
            }
        }
        public SceneBeaconEditorActions @SceneBeaconEditor => new SceneBeaconEditorActions(this);

        // SceneBiblionShowcase
        private readonly InputActionMap m_SceneBiblionShowcase;
        private ISceneBiblionShowcaseActions m_SceneBiblionShowcaseActionsCallbackInterface;
        public struct SceneBiblionShowcaseActions
        {
            private @Input m_Wrapper;
            public SceneBiblionShowcaseActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputActionMap Get() { return m_Wrapper.m_SceneBiblionShowcase; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SceneBiblionShowcaseActions set) { return set.Get(); }
            public void SetCallbacks(ISceneBiblionShowcaseActions instance)
            {
                if (m_Wrapper.m_SceneBiblionShowcaseActionsCallbackInterface != null)
                {
                }
                m_Wrapper.m_SceneBiblionShowcaseActionsCallbackInterface = instance;
                if (instance != null)
                {
                }
            }
        }
        public SceneBiblionShowcaseActions @SceneBiblionShowcase => new SceneBiblionShowcaseActions(this);

        // SceneBibliothecaEditor
        private readonly InputActionMap m_SceneBibliothecaEditor;
        private ISceneBibliothecaEditorActions m_SceneBibliothecaEditorActionsCallbackInterface;
        public struct SceneBibliothecaEditorActions
        {
            private @Input m_Wrapper;
            public SceneBibliothecaEditorActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputActionMap Get() { return m_Wrapper.m_SceneBibliothecaEditor; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SceneBibliothecaEditorActions set) { return set.Get(); }
            public void SetCallbacks(ISceneBibliothecaEditorActions instance)
            {
                if (m_Wrapper.m_SceneBibliothecaEditorActionsCallbackInterface != null)
                {
                }
                m_Wrapper.m_SceneBibliothecaEditorActionsCallbackInterface = instance;
                if (instance != null)
                {
                }
            }
        }
        public SceneBibliothecaEditorActions @SceneBibliothecaEditor => new SceneBibliothecaEditorActions(this);

        // Shared
        private readonly InputActionMap m_Shared;
        private ISharedActions m_SharedActionsCallbackInterface;
        private readonly InputAction m_Shared_Bcn_MoveLock;
        private readonly InputAction m_Shared_Bcn_UnlockAdd;
        private readonly InputAction m_Shared_Bcn_Add;
        private readonly InputAction m_Shared_Bcn_Select;
        private readonly InputAction m_Shared_Bcn_Delete;
        private readonly InputAction m_Shared_MgrCamera_SwitchTo_Toggle;
        private readonly InputAction m_Shared_MgrCamera_Zoom;
        private readonly InputAction m_Shared_MgrCamera_Move;
        private readonly InputAction m_Shared_MgrCamera_UnlockMove;
        public struct SharedActions
        {
            private @Input m_Wrapper;
            public SharedActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @Bcn_MoveLock => m_Wrapper.m_Shared_Bcn_MoveLock;
            public InputAction @Bcn_UnlockAdd => m_Wrapper.m_Shared_Bcn_UnlockAdd;
            public InputAction @Bcn_Add => m_Wrapper.m_Shared_Bcn_Add;
            public InputAction @Bcn_Select => m_Wrapper.m_Shared_Bcn_Select;
            public InputAction @Bcn_Delete => m_Wrapper.m_Shared_Bcn_Delete;
            public InputAction @MgrCamera_SwitchTo_Toggle => m_Wrapper.m_Shared_MgrCamera_SwitchTo_Toggle;
            public InputAction @MgrCamera_Zoom => m_Wrapper.m_Shared_MgrCamera_Zoom;
            public InputAction @MgrCamera_Move => m_Wrapper.m_Shared_MgrCamera_Move;
            public InputAction @MgrCamera_UnlockMove => m_Wrapper.m_Shared_MgrCamera_UnlockMove;
            public InputActionMap Get() { return m_Wrapper.m_Shared; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SharedActions set) { return set.Get(); }
            public void SetCallbacks(ISharedActions instance)
            {
                if (m_Wrapper.m_SharedActionsCallbackInterface != null)
                {
                    @Bcn_MoveLock.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_MoveLock;
                    @Bcn_MoveLock.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_MoveLock;
                    @Bcn_MoveLock.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_MoveLock;
                    @Bcn_UnlockAdd.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_UnlockAdd;
                    @Bcn_UnlockAdd.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_UnlockAdd;
                    @Bcn_UnlockAdd.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_UnlockAdd;
                    @Bcn_Add.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Add;
                    @Bcn_Add.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Add;
                    @Bcn_Add.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Add;
                    @Bcn_Select.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Select;
                    @Bcn_Select.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Select;
                    @Bcn_Select.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Select;
                    @Bcn_Delete.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Delete;
                    @Bcn_Delete.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Delete;
                    @Bcn_Delete.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnBcn_Delete;
                    @MgrCamera_SwitchTo_Toggle.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_SwitchTo_Toggle;
                    @MgrCamera_SwitchTo_Toggle.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_SwitchTo_Toggle;
                    @MgrCamera_SwitchTo_Toggle.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_SwitchTo_Toggle;
                    @MgrCamera_Zoom.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_Zoom;
                    @MgrCamera_Zoom.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_Zoom;
                    @MgrCamera_Zoom.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_Zoom;
                    @MgrCamera_Move.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_Move;
                    @MgrCamera_Move.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_Move;
                    @MgrCamera_Move.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_Move;
                    @MgrCamera_UnlockMove.started -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_UnlockMove;
                    @MgrCamera_UnlockMove.performed -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_UnlockMove;
                    @MgrCamera_UnlockMove.canceled -= m_Wrapper.m_SharedActionsCallbackInterface.OnMgrCamera_UnlockMove;
                }
                m_Wrapper.m_SharedActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Bcn_MoveLock.started += instance.OnBcn_MoveLock;
                    @Bcn_MoveLock.performed += instance.OnBcn_MoveLock;
                    @Bcn_MoveLock.canceled += instance.OnBcn_MoveLock;
                    @Bcn_UnlockAdd.started += instance.OnBcn_UnlockAdd;
                    @Bcn_UnlockAdd.performed += instance.OnBcn_UnlockAdd;
                    @Bcn_UnlockAdd.canceled += instance.OnBcn_UnlockAdd;
                    @Bcn_Add.started += instance.OnBcn_Add;
                    @Bcn_Add.performed += instance.OnBcn_Add;
                    @Bcn_Add.canceled += instance.OnBcn_Add;
                    @Bcn_Select.started += instance.OnBcn_Select;
                    @Bcn_Select.performed += instance.OnBcn_Select;
                    @Bcn_Select.canceled += instance.OnBcn_Select;
                    @Bcn_Delete.started += instance.OnBcn_Delete;
                    @Bcn_Delete.performed += instance.OnBcn_Delete;
                    @Bcn_Delete.canceled += instance.OnBcn_Delete;
                    @MgrCamera_SwitchTo_Toggle.started += instance.OnMgrCamera_SwitchTo_Toggle;
                    @MgrCamera_SwitchTo_Toggle.performed += instance.OnMgrCamera_SwitchTo_Toggle;
                    @MgrCamera_SwitchTo_Toggle.canceled += instance.OnMgrCamera_SwitchTo_Toggle;
                    @MgrCamera_Zoom.started += instance.OnMgrCamera_Zoom;
                    @MgrCamera_Zoom.performed += instance.OnMgrCamera_Zoom;
                    @MgrCamera_Zoom.canceled += instance.OnMgrCamera_Zoom;
                    @MgrCamera_Move.started += instance.OnMgrCamera_Move;
                    @MgrCamera_Move.performed += instance.OnMgrCamera_Move;
                    @MgrCamera_Move.canceled += instance.OnMgrCamera_Move;
                    @MgrCamera_UnlockMove.started += instance.OnMgrCamera_UnlockMove;
                    @MgrCamera_UnlockMove.performed += instance.OnMgrCamera_UnlockMove;
                    @MgrCamera_UnlockMove.canceled += instance.OnMgrCamera_UnlockMove;
                }
            }
        }
        public SharedActions @Shared => new SharedActions(this);
        public interface ISceneMainActions
        {
            void OnMgrScene_SwitchTo_MAIN(InputAction.CallbackContext context);
            void OnMgrScene_SwitchTo_BEACON_EDITOR(InputAction.CallbackContext context);
            void OnMgrScene_SwitchTo_BIBLION_SHOWCASE(InputAction.CallbackContext context);
            void OnMgrScene_SwitchTo_BIBLIOTHECA_SAMPLE(InputAction.CallbackContext context);
        }
        public interface ISceneBeaconEditorActions
        {
            void OnMgrCanvas_ToggleEscMenu(InputAction.CallbackContext context);
            void OnMgrCanvas_UpdatePanelBeaconSelection(InputAction.CallbackContext context);
            void OnMgrScene_ToggleActive(InputAction.CallbackContext context);
        }
        public interface ISceneBiblionShowcaseActions
        {
        }
        public interface ISceneBibliothecaEditorActions
        {
        }
        public interface ISharedActions
        {
            void OnBcn_MoveLock(InputAction.CallbackContext context);
            void OnBcn_UnlockAdd(InputAction.CallbackContext context);
            void OnBcn_Add(InputAction.CallbackContext context);
            void OnBcn_Select(InputAction.CallbackContext context);
            void OnBcn_Delete(InputAction.CallbackContext context);
            void OnMgrCamera_SwitchTo_Toggle(InputAction.CallbackContext context);
            void OnMgrCamera_Zoom(InputAction.CallbackContext context);
            void OnMgrCamera_Move(InputAction.CallbackContext context);
            void OnMgrCamera_UnlockMove(InputAction.CallbackContext context);
        }
    }
}

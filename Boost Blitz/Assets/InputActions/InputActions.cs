//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""69768abd-5449-4ee1-bb70-deaa4b9da484"",
            ""actions"": [
                {
                    ""name"": ""Player1ToggleCamera"",
                    ""type"": ""Button"",
                    ""id"": ""bddd3779-c2fd-4598-9ec2-7a1c4c0e2f7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2ToggleCamera"",
                    ""type"": ""Button"",
                    ""id"": ""3c929f74-d32e-4529-91a6-34ac50562889"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""9b1ced05-1bf8-4ce0-a218-f0a96439faff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1MoveBackward"",
                    ""type"": ""Button"",
                    ""id"": ""fc6a009b-f92a-4641-859a-1d4ccff61629"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""3205ad04-5aaa-4158-9ef0-90dca7a4e84f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""542279be-ecab-4b36-bd2f-8870c1ac2a94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1ResetCar"",
                    ""type"": ""Button"",
                    ""id"": ""fd91d133-6952-4b04-9b8f-a872f9b013a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""7cda6afd-6f04-4de7-88b9-3100ea4b5abb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2MoveBackward"",
                    ""type"": ""Button"",
                    ""id"": ""4569ecb7-480a-4d4b-8e36-8e0ff775ffdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c77b3623-6228-4c49-9e46-52468e84b7a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""b761a439-fec5-4138-aadc-8c89eab77dc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2ResetCar"",
                    ""type"": ""Button"",
                    ""id"": ""0ad417b7-aa10-4631-9c15-31dbdf64ca19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""582cb2e6-1227-47ac-86e1-26386b2ed2db"",
                    ""path"": ""<Keyboard>/#(C)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1ToggleCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80a32869-c18c-40ec-bf2d-73beb3630a30"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""462804fd-0f63-4e00-8300-5fa59b598159"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1MoveBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfa0a840-eb73-44a7-9509-5c199a12fcc2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71bcb485-e011-420c-9e95-406c159f0843"",
                    ""path"": ""<Keyboard>/#(K)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2ToggleCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d350c8f-eabc-40c4-882d-d0289b98cac2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acfb44a7-d196-42bc-a144-81038fd7e375"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1ResetCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27ae17a9-cb83-4ea9-a42d-0bcdbea0bd5f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c22613f-4fd5-4d73-bf33-061a6b89b58c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2MoveBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d035f1b6-7982-4a08-b0c4-2074baa0361a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76002cd7-5b67-4ea6-9357-5a853589f100"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Hold,Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac33fea8-6935-4f66-84a6-0dd92459e692"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2ResetCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Player1ToggleCamera = m_PlayerControls.FindAction("Player1ToggleCamera", throwIfNotFound: true);
        m_PlayerControls_Player2ToggleCamera = m_PlayerControls.FindAction("Player2ToggleCamera", throwIfNotFound: true);
        m_PlayerControls_Player1MoveForward = m_PlayerControls.FindAction("Player1MoveForward", throwIfNotFound: true);
        m_PlayerControls_Player1MoveBackward = m_PlayerControls.FindAction("Player1MoveBackward", throwIfNotFound: true);
        m_PlayerControls_Player1RotateLeft = m_PlayerControls.FindAction("Player1RotateLeft", throwIfNotFound: true);
        m_PlayerControls_Player1RotateRight = m_PlayerControls.FindAction("Player1RotateRight", throwIfNotFound: true);
        m_PlayerControls_Player1ResetCar = m_PlayerControls.FindAction("Player1ResetCar", throwIfNotFound: true);
        m_PlayerControls_Player2MoveForward = m_PlayerControls.FindAction("Player2MoveForward", throwIfNotFound: true);
        m_PlayerControls_Player2MoveBackward = m_PlayerControls.FindAction("Player2MoveBackward", throwIfNotFound: true);
        m_PlayerControls_Player2RotateLeft = m_PlayerControls.FindAction("Player2RotateLeft", throwIfNotFound: true);
        m_PlayerControls_Player2RotateRight = m_PlayerControls.FindAction("Player2RotateRight", throwIfNotFound: true);
        m_PlayerControls_Player2ResetCar = m_PlayerControls.FindAction("Player2ResetCar", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private List<IPlayerControlsActions> m_PlayerControlsActionsCallbackInterfaces = new List<IPlayerControlsActions>();
    private readonly InputAction m_PlayerControls_Player1ToggleCamera;
    private readonly InputAction m_PlayerControls_Player2ToggleCamera;
    private readonly InputAction m_PlayerControls_Player1MoveForward;
    private readonly InputAction m_PlayerControls_Player1MoveBackward;
    private readonly InputAction m_PlayerControls_Player1RotateLeft;
    private readonly InputAction m_PlayerControls_Player1RotateRight;
    private readonly InputAction m_PlayerControls_Player1ResetCar;
    private readonly InputAction m_PlayerControls_Player2MoveForward;
    private readonly InputAction m_PlayerControls_Player2MoveBackward;
    private readonly InputAction m_PlayerControls_Player2RotateLeft;
    private readonly InputAction m_PlayerControls_Player2RotateRight;
    private readonly InputAction m_PlayerControls_Player2ResetCar;
    public struct PlayerControlsActions
    {
        private @InputActions m_Wrapper;
        public PlayerControlsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1ToggleCamera => m_Wrapper.m_PlayerControls_Player1ToggleCamera;
        public InputAction @Player2ToggleCamera => m_Wrapper.m_PlayerControls_Player2ToggleCamera;
        public InputAction @Player1MoveForward => m_Wrapper.m_PlayerControls_Player1MoveForward;
        public InputAction @Player1MoveBackward => m_Wrapper.m_PlayerControls_Player1MoveBackward;
        public InputAction @Player1RotateLeft => m_Wrapper.m_PlayerControls_Player1RotateLeft;
        public InputAction @Player1RotateRight => m_Wrapper.m_PlayerControls_Player1RotateRight;
        public InputAction @Player1ResetCar => m_Wrapper.m_PlayerControls_Player1ResetCar;
        public InputAction @Player2MoveForward => m_Wrapper.m_PlayerControls_Player2MoveForward;
        public InputAction @Player2MoveBackward => m_Wrapper.m_PlayerControls_Player2MoveBackward;
        public InputAction @Player2RotateLeft => m_Wrapper.m_PlayerControls_Player2RotateLeft;
        public InputAction @Player2RotateRight => m_Wrapper.m_PlayerControls_Player2RotateRight;
        public InputAction @Player2ResetCar => m_Wrapper.m_PlayerControls_Player2ResetCar;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Add(instance);
            @Player1ToggleCamera.started += instance.OnPlayer1ToggleCamera;
            @Player1ToggleCamera.performed += instance.OnPlayer1ToggleCamera;
            @Player1ToggleCamera.canceled += instance.OnPlayer1ToggleCamera;
            @Player2ToggleCamera.started += instance.OnPlayer2ToggleCamera;
            @Player2ToggleCamera.performed += instance.OnPlayer2ToggleCamera;
            @Player2ToggleCamera.canceled += instance.OnPlayer2ToggleCamera;
            @Player1MoveForward.started += instance.OnPlayer1MoveForward;
            @Player1MoveForward.performed += instance.OnPlayer1MoveForward;
            @Player1MoveForward.canceled += instance.OnPlayer1MoveForward;
            @Player1MoveBackward.started += instance.OnPlayer1MoveBackward;
            @Player1MoveBackward.performed += instance.OnPlayer1MoveBackward;
            @Player1MoveBackward.canceled += instance.OnPlayer1MoveBackward;
            @Player1RotateLeft.started += instance.OnPlayer1RotateLeft;
            @Player1RotateLeft.performed += instance.OnPlayer1RotateLeft;
            @Player1RotateLeft.canceled += instance.OnPlayer1RotateLeft;
            @Player1RotateRight.started += instance.OnPlayer1RotateRight;
            @Player1RotateRight.performed += instance.OnPlayer1RotateRight;
            @Player1RotateRight.canceled += instance.OnPlayer1RotateRight;
            @Player1ResetCar.started += instance.OnPlayer1ResetCar;
            @Player1ResetCar.performed += instance.OnPlayer1ResetCar;
            @Player1ResetCar.canceled += instance.OnPlayer1ResetCar;
            @Player2MoveForward.started += instance.OnPlayer2MoveForward;
            @Player2MoveForward.performed += instance.OnPlayer2MoveForward;
            @Player2MoveForward.canceled += instance.OnPlayer2MoveForward;
            @Player2MoveBackward.started += instance.OnPlayer2MoveBackward;
            @Player2MoveBackward.performed += instance.OnPlayer2MoveBackward;
            @Player2MoveBackward.canceled += instance.OnPlayer2MoveBackward;
            @Player2RotateLeft.started += instance.OnPlayer2RotateLeft;
            @Player2RotateLeft.performed += instance.OnPlayer2RotateLeft;
            @Player2RotateLeft.canceled += instance.OnPlayer2RotateLeft;
            @Player2RotateRight.started += instance.OnPlayer2RotateRight;
            @Player2RotateRight.performed += instance.OnPlayer2RotateRight;
            @Player2RotateRight.canceled += instance.OnPlayer2RotateRight;
            @Player2ResetCar.started += instance.OnPlayer2ResetCar;
            @Player2ResetCar.performed += instance.OnPlayer2ResetCar;
            @Player2ResetCar.canceled += instance.OnPlayer2ResetCar;
        }

        private void UnregisterCallbacks(IPlayerControlsActions instance)
        {
            @Player1ToggleCamera.started -= instance.OnPlayer1ToggleCamera;
            @Player1ToggleCamera.performed -= instance.OnPlayer1ToggleCamera;
            @Player1ToggleCamera.canceled -= instance.OnPlayer1ToggleCamera;
            @Player2ToggleCamera.started -= instance.OnPlayer2ToggleCamera;
            @Player2ToggleCamera.performed -= instance.OnPlayer2ToggleCamera;
            @Player2ToggleCamera.canceled -= instance.OnPlayer2ToggleCamera;
            @Player1MoveForward.started -= instance.OnPlayer1MoveForward;
            @Player1MoveForward.performed -= instance.OnPlayer1MoveForward;
            @Player1MoveForward.canceled -= instance.OnPlayer1MoveForward;
            @Player1MoveBackward.started -= instance.OnPlayer1MoveBackward;
            @Player1MoveBackward.performed -= instance.OnPlayer1MoveBackward;
            @Player1MoveBackward.canceled -= instance.OnPlayer1MoveBackward;
            @Player1RotateLeft.started -= instance.OnPlayer1RotateLeft;
            @Player1RotateLeft.performed -= instance.OnPlayer1RotateLeft;
            @Player1RotateLeft.canceled -= instance.OnPlayer1RotateLeft;
            @Player1RotateRight.started -= instance.OnPlayer1RotateRight;
            @Player1RotateRight.performed -= instance.OnPlayer1RotateRight;
            @Player1RotateRight.canceled -= instance.OnPlayer1RotateRight;
            @Player1ResetCar.started -= instance.OnPlayer1ResetCar;
            @Player1ResetCar.performed -= instance.OnPlayer1ResetCar;
            @Player1ResetCar.canceled -= instance.OnPlayer1ResetCar;
            @Player2MoveForward.started -= instance.OnPlayer2MoveForward;
            @Player2MoveForward.performed -= instance.OnPlayer2MoveForward;
            @Player2MoveForward.canceled -= instance.OnPlayer2MoveForward;
            @Player2MoveBackward.started -= instance.OnPlayer2MoveBackward;
            @Player2MoveBackward.performed -= instance.OnPlayer2MoveBackward;
            @Player2MoveBackward.canceled -= instance.OnPlayer2MoveBackward;
            @Player2RotateLeft.started -= instance.OnPlayer2RotateLeft;
            @Player2RotateLeft.performed -= instance.OnPlayer2RotateLeft;
            @Player2RotateLeft.canceled -= instance.OnPlayer2RotateLeft;
            @Player2RotateRight.started -= instance.OnPlayer2RotateRight;
            @Player2RotateRight.performed -= instance.OnPlayer2RotateRight;
            @Player2RotateRight.canceled -= instance.OnPlayer2RotateRight;
            @Player2ResetCar.started -= instance.OnPlayer2ResetCar;
            @Player2ResetCar.performed -= instance.OnPlayer2ResetCar;
            @Player2ResetCar.canceled -= instance.OnPlayer2ResetCar;
        }

        public void RemoveCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnPlayer1ToggleCamera(InputAction.CallbackContext context);
        void OnPlayer2ToggleCamera(InputAction.CallbackContext context);
        void OnPlayer1MoveForward(InputAction.CallbackContext context);
        void OnPlayer1MoveBackward(InputAction.CallbackContext context);
        void OnPlayer1RotateLeft(InputAction.CallbackContext context);
        void OnPlayer1RotateRight(InputAction.CallbackContext context);
        void OnPlayer1ResetCar(InputAction.CallbackContext context);
        void OnPlayer2MoveForward(InputAction.CallbackContext context);
        void OnPlayer2MoveBackward(InputAction.CallbackContext context);
        void OnPlayer2RotateLeft(InputAction.CallbackContext context);
        void OnPlayer2RotateRight(InputAction.CallbackContext context);
        void OnPlayer2ResetCar(InputAction.CallbackContext context);
    }
}

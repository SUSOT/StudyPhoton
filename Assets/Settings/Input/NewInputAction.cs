//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/Input/NewInputAction.inputactions
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

public partial class @NewInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewInputAction"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""658ac619-10d7-42b4-9e6d-f026192a9505"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a84181b1-32a1-4cd6-a146-727345a7b38b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""eccc3cd2-4093-4b2c-bcdf-6506a2211b7c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74b78781-61ba-47fa-b007-38ceb99d5b5f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KetboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8353ba02-101a-4d25-9f6b-1c7a0ca93083"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06d70549-1e65-4dde-b37e-fa221cadf608"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KetboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""96063946-de88-4157-982f-c54d19f9c091"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KetboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KetboardMouse"",
            ""bindingGroup"": ""KetboardMouse"",
            ""devices"": []
        }
    ]
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_Jump = m_PlayerInput.FindAction("Jump", throwIfNotFound: true);
        m_PlayerInput_Move = m_PlayerInput.FindAction("Move", throwIfNotFound: true);
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

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private List<IPlayerInputActions> m_PlayerInputActionsCallbackInterfaces = new List<IPlayerInputActions>();
    private readonly InputAction m_PlayerInput_Jump;
    private readonly InputAction m_PlayerInput_Move;
    public struct PlayerInputActions
    {
        private @NewInputAction m_Wrapper;
        public PlayerInputActions(@NewInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerInput_Jump;
        public InputAction @Move => m_Wrapper.m_PlayerInput_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInputActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayerInputActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInputActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    private int m_KetboardMouseSchemeIndex = -1;
    public InputControlScheme KetboardMouseScheme
    {
        get
        {
            if (m_KetboardMouseSchemeIndex == -1) m_KetboardMouseSchemeIndex = asset.FindControlSchemeIndex("KetboardMouse");
            return asset.controlSchemes[m_KetboardMouseSchemeIndex];
        }
    }
    public interface IPlayerInputActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}

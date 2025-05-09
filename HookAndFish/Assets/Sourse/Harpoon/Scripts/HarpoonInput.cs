//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Sourse/Harpoon/Scripts/HarpoonInput.inputactions
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

public partial class @HarpoonInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @HarpoonInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HarpoonInput"",
    ""maps"": [
        {
            ""name"": ""Harpoon"",
            ""id"": ""bb49cce5-ea25-4e5e-b0f9-c6742f72dda5"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""789ce225-5cf4-497a-a90e-44d3938650a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""471532fa-c7f4-49c5-922a-aa58664f36ac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7e93903d-b4b5-4465-9f03-592a2c1c5ca5"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3c12b8c4-1d01-4852-8695-7d4acc6b4268"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""207b2954-67c8-4a95-9dae-01f0e12d017d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1461dd87-4080-4213-ba52-81c4889ac7da"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""42414d5a-e7d1-4187-b176-bd70d3f7e0b2"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Android"",
            ""bindingGroup"": ""Android"",
            ""devices"": [
                {
                    ""devicePath"": ""<WebGLGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Harpoon
        m_Harpoon = asset.FindActionMap("Harpoon", throwIfNotFound: true);
        m_Harpoon_Rotation = m_Harpoon.FindAction("Rotation", throwIfNotFound: true);
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

    // Harpoon
    private readonly InputActionMap m_Harpoon;
    private List<IHarpoonActions> m_HarpoonActionsCallbackInterfaces = new List<IHarpoonActions>();
    private readonly InputAction m_Harpoon_Rotation;
    public struct HarpoonActions
    {
        private @HarpoonInput m_Wrapper;
        public HarpoonActions(@HarpoonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_Harpoon_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_Harpoon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HarpoonActions set) { return set.Get(); }
        public void AddCallbacks(IHarpoonActions instance)
        {
            if (instance == null || m_Wrapper.m_HarpoonActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HarpoonActionsCallbackInterfaces.Add(instance);
            @Rotation.started += instance.OnRotation;
            @Rotation.performed += instance.OnRotation;
            @Rotation.canceled += instance.OnRotation;
        }

        private void UnregisterCallbacks(IHarpoonActions instance)
        {
            @Rotation.started -= instance.OnRotation;
            @Rotation.performed -= instance.OnRotation;
            @Rotation.canceled -= instance.OnRotation;
        }

        public void RemoveCallbacks(IHarpoonActions instance)
        {
            if (m_Wrapper.m_HarpoonActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHarpoonActions instance)
        {
            foreach (var item in m_Wrapper.m_HarpoonActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HarpoonActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HarpoonActions @Harpoon => new HarpoonActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    private int m_AndroidSchemeIndex = -1;
    public InputControlScheme AndroidScheme
    {
        get
        {
            if (m_AndroidSchemeIndex == -1) m_AndroidSchemeIndex = asset.FindControlSchemeIndex("Android");
            return asset.controlSchemes[m_AndroidSchemeIndex];
        }
    }
    public interface IHarpoonActions
    {
        void OnRotation(InputAction.CallbackContext context);
    }
}

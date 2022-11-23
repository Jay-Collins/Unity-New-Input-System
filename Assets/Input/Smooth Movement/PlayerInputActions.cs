//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/Smooth Movement/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""20882c8e-c81d-4902-b71d-a87ef19c58cd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""558b5f50-0c05-43ae-ae48-ff8d8c40cd4d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""65eae641-df38-47bb-8b3d-f5cc0c824285"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7476efda-7667-4b68-be2a-90924de5aee2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""78f21164-817e-4074-9400-e9d5f9738442"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""081a7c7c-abda-41dc-84bf-af12480341fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""061fac37-6b6d-4400-9ef3-92cbfead3fdc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""RandomColor"",
            ""id"": ""526388ec-74a9-42f7-99f0-da0ec16f2775"",
            ""actions"": [
                {
                    ""name"": ""Randomize"",
                    ""type"": ""Button"",
                    ""id"": ""0c83ec9c-36f3-4f2e-8b52-21bb04022160"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""61c50a5d-7005-41fe-a1ac-c81543a0598f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeControls"",
                    ""type"": ""Button"",
                    ""id"": ""aae33953-6a3f-4b38-b877-18157411cc33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cde3cf09-a10b-46d1-a394-dd4e466c6b84"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Randomize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fcf270b8-34c4-4dc2-a5df-d99fc934b221"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c22cd1dd-cc94-4fd3-ac81-a5f2486441ff"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f8d19cb9-7465-44c0-af48-f765eb1e3643"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fc192094-bb23-448c-a221-1b71741918da"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ef03a294-c3d0-4c90-83ea-33e9b5e78b97"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9c2e7556-749b-4d2a-a685-e16a94349d0a"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Driving"",
            ""id"": ""c9cd7d3a-bc8e-4dc2-b8e1-eb8cda1e8739"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ad8a5759-5ec7-48f9-9a6a-741f258b265b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeControls"",
                    ""type"": ""Button"",
                    ""id"": ""abffd57d-e44f-40b2-b4bf-83778e9d2cbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bc765a56-e814-4832-861f-60472d4df5f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3a59ecdb-d3ca-4c96-82eb-1c927413d0ef"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""94feab7b-fc2c-4797-b0b5-a9b400702fda"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""16d21e12-1f75-49d2-86ea-901a8247d9f6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a77e4144-f371-41cf-aaf0-fb00ba99a928"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ecda4215-0481-4e6c-a45c-7306a1749def"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Sphere"",
            ""id"": ""49296b1d-28ee-4e59-aaaf-386cf506f3b3"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4c070f8c-5fe3-4202-9807-7c7e3eec4c4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ebb3f119-7c34-4e39-9ab3-3e728f2be976"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Slider"",
            ""id"": ""75c69c93-9a1f-47a7-9d0c-5dc1815f320d"",
            ""actions"": [
                {
                    ""name"": ""Charge"",
                    ""type"": ""Button"",
                    ""id"": ""7d98edbb-879f-44e3-b1c8-347629df9980"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ac4dbea4-1a2b-49da-bdeb-e7afa6c276c6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        // RandomColor
        m_RandomColor = asset.FindActionMap("RandomColor", throwIfNotFound: true);
        m_RandomColor_Randomize = m_RandomColor.FindAction("Randomize", throwIfNotFound: true);
        m_RandomColor_Movement = m_RandomColor.FindAction("Movement", throwIfNotFound: true);
        m_RandomColor_ChangeControls = m_RandomColor.FindAction("ChangeControls", throwIfNotFound: true);
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Movement = m_Driving.FindAction("Movement", throwIfNotFound: true);
        m_Driving_ChangeControls = m_Driving.FindAction("ChangeControls", throwIfNotFound: true);
        // Sphere
        m_Sphere = asset.FindActionMap("Sphere", throwIfNotFound: true);
        m_Sphere_Jump = m_Sphere.FindAction("Jump", throwIfNotFound: true);
        // Slider
        m_Slider = asset.FindActionMap("Slider", throwIfNotFound: true);
        m_Slider_Charge = m_Slider.FindAction("Charge", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // RandomColor
    private readonly InputActionMap m_RandomColor;
    private IRandomColorActions m_RandomColorActionsCallbackInterface;
    private readonly InputAction m_RandomColor_Randomize;
    private readonly InputAction m_RandomColor_Movement;
    private readonly InputAction m_RandomColor_ChangeControls;
    public struct RandomColorActions
    {
        private @PlayerInputActions m_Wrapper;
        public RandomColorActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Randomize => m_Wrapper.m_RandomColor_Randomize;
        public InputAction @Movement => m_Wrapper.m_RandomColor_Movement;
        public InputAction @ChangeControls => m_Wrapper.m_RandomColor_ChangeControls;
        public InputActionMap Get() { return m_Wrapper.m_RandomColor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RandomColorActions set) { return set.Get(); }
        public void SetCallbacks(IRandomColorActions instance)
        {
            if (m_Wrapper.m_RandomColorActionsCallbackInterface != null)
            {
                @Randomize.started -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnRandomize;
                @Randomize.performed -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnRandomize;
                @Randomize.canceled -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnRandomize;
                @Movement.started -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnMovement;
                @ChangeControls.started -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnChangeControls;
                @ChangeControls.performed -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnChangeControls;
                @ChangeControls.canceled -= m_Wrapper.m_RandomColorActionsCallbackInterface.OnChangeControls;
            }
            m_Wrapper.m_RandomColorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Randomize.started += instance.OnRandomize;
                @Randomize.performed += instance.OnRandomize;
                @Randomize.canceled += instance.OnRandomize;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ChangeControls.started += instance.OnChangeControls;
                @ChangeControls.performed += instance.OnChangeControls;
                @ChangeControls.canceled += instance.OnChangeControls;
            }
        }
    }
    public RandomColorActions @RandomColor => new RandomColorActions(this);

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Movement;
    private readonly InputAction m_Driving_ChangeControls;
    public struct DrivingActions
    {
        private @PlayerInputActions m_Wrapper;
        public DrivingActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Driving_Movement;
        public InputAction @ChangeControls => m_Wrapper.m_Driving_ChangeControls;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMovement;
                @ChangeControls.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnChangeControls;
                @ChangeControls.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnChangeControls;
                @ChangeControls.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnChangeControls;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ChangeControls.started += instance.OnChangeControls;
                @ChangeControls.performed += instance.OnChangeControls;
                @ChangeControls.canceled += instance.OnChangeControls;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // Sphere
    private readonly InputActionMap m_Sphere;
    private ISphereActions m_SphereActionsCallbackInterface;
    private readonly InputAction m_Sphere_Jump;
    public struct SphereActions
    {
        private @PlayerInputActions m_Wrapper;
        public SphereActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Sphere_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Sphere; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SphereActions set) { return set.Get(); }
        public void SetCallbacks(ISphereActions instance)
        {
            if (m_Wrapper.m_SphereActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_SphereActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_SphereActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_SphereActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_SphereActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public SphereActions @Sphere => new SphereActions(this);

    // Slider
    private readonly InputActionMap m_Slider;
    private ISliderActions m_SliderActionsCallbackInterface;
    private readonly InputAction m_Slider_Charge;
    public struct SliderActions
    {
        private @PlayerInputActions m_Wrapper;
        public SliderActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Charge => m_Wrapper.m_Slider_Charge;
        public InputActionMap Get() { return m_Wrapper.m_Slider; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SliderActions set) { return set.Get(); }
        public void SetCallbacks(ISliderActions instance)
        {
            if (m_Wrapper.m_SliderActionsCallbackInterface != null)
            {
                @Charge.started -= m_Wrapper.m_SliderActionsCallbackInterface.OnCharge;
                @Charge.performed -= m_Wrapper.m_SliderActionsCallbackInterface.OnCharge;
                @Charge.canceled -= m_Wrapper.m_SliderActionsCallbackInterface.OnCharge;
            }
            m_Wrapper.m_SliderActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Charge.started += instance.OnCharge;
                @Charge.performed += instance.OnCharge;
                @Charge.canceled += instance.OnCharge;
            }
        }
    }
    public SliderActions @Slider => new SliderActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IRandomColorActions
    {
        void OnRandomize(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnChangeControls(InputAction.CallbackContext context);
    }
    public interface IDrivingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnChangeControls(InputAction.CallbackContext context);
    }
    public interface ISphereActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ISliderActions
    {
        void OnCharge(InputAction.CallbackContext context);
    }
}
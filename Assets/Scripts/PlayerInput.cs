// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5c6da54e-8d43-4bca-955e-506d117cae24"",
            ""actions"": [
                {
                    ""name"": ""MoveToNextPlayerState"",
                    ""type"": ""Button"",
                    ""id"": ""df98a74d-6cae-472f-97b0-d1ab097c2d2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b85de67-8485-42d6-b9f9-0351e45cee57"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MobileInput"",
                    ""action"": ""MoveToNextPlayerState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MobileInput"",
            ""bindingGroup"": ""MobileInput"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveToNextPlayerState = m_Player.FindAction("MoveToNextPlayerState", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveToNextPlayerState;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveToNextPlayerState => m_Wrapper.m_Player_MoveToNextPlayerState;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveToNextPlayerState.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveToNextPlayerState;
                @MoveToNextPlayerState.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveToNextPlayerState;
                @MoveToNextPlayerState.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveToNextPlayerState;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveToNextPlayerState.started += instance.OnMoveToNextPlayerState;
                @MoveToNextPlayerState.performed += instance.OnMoveToNextPlayerState;
                @MoveToNextPlayerState.canceled += instance.OnMoveToNextPlayerState;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MobileInputSchemeIndex = -1;
    public InputControlScheme MobileInputScheme
    {
        get
        {
            if (m_MobileInputSchemeIndex == -1) m_MobileInputSchemeIndex = asset.FindControlSchemeIndex("MobileInput");
            return asset.controlSchemes[m_MobileInputSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoveToNextPlayerState(InputAction.CallbackContext context);
    }
}

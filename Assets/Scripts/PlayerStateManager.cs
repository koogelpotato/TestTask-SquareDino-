using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerStateManager : MonoBehaviour
{
    private PlayerInput inputActions;
    private PlayerState currentState;
    private PlayerMovementState playerMovementState = new PlayerMovementState();
    private PlayerPauseState playerPauseState = new  PlayerPauseState();
    private PlayerShootState playerShootState = new PlayerShootState();

    private void Start()
    {
        inputActions = new PlayerInput();
        inputActions.Player.Enable();
        currentState = playerMovementState;
        inputActions.Player.MoveToNextPlayerState.performed += ChangeState;

    }
    private void ChangeState(InputAction.CallbackContext context)
    {
        //currentState.EnterState(this);
        Debug.Log("Action Performed");
    }
    private void Update()
    {
        
    }

}

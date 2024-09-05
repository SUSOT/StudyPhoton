using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static NewInputAction;

[CreateAssetMenu(menuName = "SO/InputReader")]
public class InputReader : ScriptableObject, IPlayerInputActions
{
    public event Action<Vector2> MovementEvent;
    
    public event Action OnJumpPressed;

    private NewInputAction _newInputAction;

    public Vector2 _inputVector;

    private void OnEnable()
    {
        if (_newInputAction == null)
        {
            _newInputAction = new NewInputAction();
            _newInputAction.Enable();
            _newInputAction.PlayerInput.SetCallbacks(this);
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        OnJumpPressed?.Invoke();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _inputVector = context.ReadValue<Vector2>();
        MovementEvent?.Invoke(_inputVector);
    }
}

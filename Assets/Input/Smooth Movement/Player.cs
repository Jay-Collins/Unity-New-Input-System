using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _playerInput;

    private void Start()
    {
        _playerInput = new PlayerInputActions();
        
        _playerInput.Player.Enable();
    }

    private void Update()
    {
        CalculateMovement();
    }

    private void CalculateMovement()
    {
        // poll or check input readings

        var move = _playerInput.Player.Movement.ReadValue<Vector2>();

        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime);
    }
}

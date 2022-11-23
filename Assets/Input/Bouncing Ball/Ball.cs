using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    private PlayerInputActions _playerInput;
    private Rigidbody _rB;

    private void Start()
    {
        _playerInput = new PlayerInputActions();
        _playerInput.Sphere.Enable();
        
        _playerInput.Sphere.Jump.canceled += Bounce;
        _rB = GetComponent<Rigidbody>();
    }

    private void Bounce(InputAction.CallbackContext obj)
    {
        if (!_rB) return;
        var forceEffect = obj.duration;
        _rB.AddForce(Vector3.up * (25 * (float)forceEffect), ForceMode.Impulse);
    }
    
}

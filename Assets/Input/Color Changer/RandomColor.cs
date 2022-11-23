using System;
using System.Diagnostics.Eventing.Reader;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = System.Random;

public class RandomColor : MonoBehaviour
{
    private PlayerInputActions _playerInput;
    [SerializeField] private int _rotateSpeed = 40;
    private bool _controlType;

    private void Start()
    {
        _playerInput = new PlayerInputActions();
        _playerInput.RandomColor.Enable();
        
        _playerInput.RandomColor.Randomize.performed += RandomizeOnperformed;
        _playerInput.RandomColor.ChangeControls.performed += ControlSelector;

        _playerInput.Driving.ChangeControls.performed += ControlSelector;
    }

    private void Update()
    {
        Movement();
    }

    private void RandomizeOnperformed(InputAction.CallbackContext obj)
    {
        if (TryGetComponent(out MeshRenderer mesh))
        {
            mesh.material.color = UnityEngine.Random.ColorHSV();
        }
    }

    private void Movement()
    {
        switch (_controlType)
        {
            // ---random color movement--- //
            case false:
            {
                var randomColorMove = _playerInput.RandomColor.Movement.ReadValue<Vector2>();

                transform.Rotate(new Vector3(0, randomColorMove.x, 0) * (_rotateSpeed * Time.deltaTime));
                break;
            }
            
            // ---driving movement--- //
            case true:
            {
                var drivingMove = _playerInput.Driving.Movement.ReadValue<Vector2>();

                transform.Translate(new Vector3(drivingMove.x, 0, drivingMove.y) * Time.deltaTime);
                break;
            }
        }
    }

    private void ControlSelector(InputAction.CallbackContext obj)
    {
        // flip _controlType bool
        _controlType = !_controlType;

        switch (_controlType)
        {
            case true:
                // disable action maps
                DisableActionMaps();
                
                // enable Driving action map
                _playerInput.Driving.Enable();
                break;
            case false:
                // disable action maps
                DisableActionMaps();
                
                // enable RandomColor action map
                _playerInput.RandomColor.Enable();
                break;
        }
    }

    private void DisableActionMaps()
    {
        _playerInput.RandomColor.Disable();
        _playerInput.Driving.Disable();
    }
}

using System;
using System.Collections;
using Unity.VisualScripting;
using Unity.UIElements;
using  UnityEngine.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class Slider : MonoBehaviour
{
    private PlayerInputActions _playerInput;
    [SerializeField] private UnityEngine.UI.Slider _slider;
    private static float _chargeProgress;
    private bool _isCharging;
    [SerializeField] private float _chargeTime = 5f;
    [SerializeField] private float _chargeDrainTime = 1f;

    private void Start()
    {
        _playerInput = new PlayerInputActions();
        _playerInput.Slider.Enable();

        _playerInput.Slider.Charge.started += Charge_started;
        _playerInput.Slider.Charge.canceled += Charge_canceled;

        _slider = GetComponent<UnityEngine.UI.Slider>();
    }
    
    private void Charge_started(InputAction.CallbackContext obj)
    {
        // reduce charging
        
        _isCharging = true;
        StartCoroutine(ChargeBarRoutine());
    }

    private void Charge_canceled(InputAction.CallbackContext obj)
    {
        // increase charging

        _isCharging = false;
    }
    
    private IEnumerator ChargeBarRoutine()
    {
        while (_isCharging)
        {
            _slider.value += (1.0f * Time.deltaTime) / _chargeTime;
            yield return null;
        }

        while (_slider.value > 0 && !_isCharging)
        {
            _slider.value -= (1.0f * Time.deltaTime) / _chargeDrainTime;
            yield return null;
        }
    }
}

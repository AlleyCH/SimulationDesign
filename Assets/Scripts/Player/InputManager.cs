// manages input 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public RocketshipController rocketShipController;

    private Vector3 moveInput;
    private Vector3 rotateInput;

    public void OnMoveForward(InputAction.CallbackContext context)
    {
        float inputValue = context.ReadValue<float>();

        //moveInput.z = context.ReadValue<float>();
        if (inputValue > 0f)
        {
            moveInput.z = inputValue;
            rocketShipController.Move(moveInput);
            Debug.Log("Are you moving bruv??? pressing w?? " + inputValue);
        }

    }

    public void OnMoveBackward(InputAction.CallbackContext context)
    {
        float inputValue = context.ReadValue<float>();

       // moveInput.z = -context.ReadValue<float>();
        rocketShipController.Move(moveInput);
        if (inputValue < 0f)
        {
            moveInput.z = inputValue;
            rocketShipController.Move(moveInput);
            Debug.Log("Are you moving bruv??? pressing s?? " + inputValue);
        }
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotateInput = context.ReadValue<Vector2>();
        rocketShipController.Rotate(rotateInput);
    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2RVC : MonoBehaviour
{
    public Camera rearViewCamera;
    public Camera mainCamera;
    private bool isEnabled;
    private InputActions inputActions;
    // Start is called before the first frame update
    void Awake()
    {
        // Initialize the input actions
        inputActions = new InputActions();
        isEnabled = false;
        rearViewCamera.depth = -2;
        rearViewCamera.enabled = false;
    }

    void OnEnable()
    {
        // Enable the ToggleCamera action
        inputActions.PlayerControls.Player2ToggleCamera.performed += ToggleCamera;
        inputActions.PlayerControls.Enable();
    }

    void OnDisable()
    {
        // Disable the ToggleCamera action
        inputActions.PlayerControls.Player2ToggleCamera.performed -= ToggleCamera;
        inputActions.PlayerControls.Disable();
    }

    private void ToggleCamera(InputAction.CallbackContext context)
    {
        // Toggle the camera
        isEnabled = !isEnabled;
        rearViewCamera.depth = isEnabled ? 1 : -2;
        if (rearViewCamera.depth == -2)
        {
            // turn off the camera
            rearViewCamera.enabled = false;
            mainCamera.enabled = true;
        } 
        else
        {
            rearViewCamera.enabled = true;
            mainCamera.enabled = false;
        }
    }
}

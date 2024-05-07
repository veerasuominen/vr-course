using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject rayCastHands;
    public GameObject normalHands;
    public InputActionReference openMenuAction;

    // Start is called before the first frame update
    private void Awake()
    {
        openMenuAction.action.Enable();
        openMenuAction.action.performed += ToggleMenu;
        InputSystem.onDeviceChange += OnDeviceChange;
        rayCastHands.SetActive(false);
    }

    private void OnDestroy()
    {
        openMenuAction.action.Disable();
        openMenuAction.action.performed -= ToggleMenu;
        InputSystem.onDeviceChange -= OnDeviceChange;
    }

    private void EnableRaycast()
    {
        rayCastHands.SetActive(!rayCastHands.activeSelf);
    }

    private void ToggleMenu(InputAction.CallbackContext context)
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
        rayCastHands.SetActive(!rayCastHands.activeSelf);
        normalHands.SetActive(!normalHands.activeSelf);
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Disconnected:
                openMenuAction.action.Disable();
                openMenuAction.action.performed -= ToggleMenu;
                break;

            case InputDeviceChange.Reconnected:
                openMenuAction.action.Enable();
                openMenuAction.action.performed += ToggleMenu;
                break;
        }
    }
}
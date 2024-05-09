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
    {   //makes sure menu is inactive as the game starts
        menuPanel.SetActive(false);

        //Enables InputActions
        openMenuAction.action.Enable();
        openMenuAction.action.performed += ToggleMenu;
        InputSystem.onDeviceChange += OnDeviceChange;
        //turns off raycast controllers, makes sure direct interaction hands are on
        rayCastHands.SetActive(false);
        normalHands.SetActive(true);
    }

    private void OnDestroy()
    {
        openMenuAction.action.Disable();
        openMenuAction.action.performed -= ToggleMenu;
        InputSystem.onDeviceChange -= OnDeviceChange;
    }

    private void ToggleRaycast()
    {
        //Toggles the different XR controllers
        rayCastHands.SetActive(!rayCastHands.activeSelf);
        normalHands.SetActive(!normalHands.activeSelf);
    }

    public void ToggleMenu(InputAction.CallbackContext context)
    {
        //Toggles menu, timescale and XR hands
        menuPanel.SetActive(!menuPanel.activeSelf);
        ToggleRaycast();
        ToggleTimeScale();
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

    public void OnMenu()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
        ToggleRaycast();
        ToggleTimeScale();
    }

    private void ToggleTimeScale()
    {
        //Toggles timescale
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Debug.Log("Paused");
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Debug.Log("Resume");
    }
}
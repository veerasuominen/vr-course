using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customInput : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;

    public void OnMenu()
    {
        menuCanvas.SetActive(false);
        Debug.Log("Menu button pressed");
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
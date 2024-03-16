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
}
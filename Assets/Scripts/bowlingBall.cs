using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingBall : MonoBehaviour
{
    public Material newMaterial;
    public Material originalMaterial;

    public void HoverEnter()
    {
        Debug.Log("hover enter");
        gameObject.GetComponent<MeshRenderer>().material = newMaterial;
    }

    public void HoverExit()
    {
        Debug.Log("hover exit");
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
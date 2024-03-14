using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 1.0f;

    // Update is called once per frame
    private void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
    }
}
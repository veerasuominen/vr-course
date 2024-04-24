using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CenterOfGravity : MonoBehaviour
{
    public Vector3 centerOfMass;
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass;
    }

    // Update is called once per frame
    private void Update()
    {
#if UNITY_EDITOR
        rb.centerOfMass = centerOfMass;
        rb.WakeUp();
#endif
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position + transform.rotation * centerOfMass, .05f);
    }
}
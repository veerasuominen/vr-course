using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public GameObject scanner;
    public float range = 1;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Scan();
        }
    }

    private void Scan()
    {
        RaycastHit hit;

        if (Physics.Raycast(scanner.transform.position, scanner.transform.forward, out hit, range)
            && hit.transform.name == "Code")
        {
        }
    }
}
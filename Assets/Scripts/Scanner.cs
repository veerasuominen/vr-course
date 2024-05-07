using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scanner : MonoBehaviour
{
    public GameObject scanner;
    public TMP_Text scannedCount;
    public float scannedNumber;
    public float range = 1;
    public string textString;

    // Start is called before the first frame update
    private void Start()
    {
        scannedNumber = 0;
        textString = "cats";
        scannedCount.text = scannedNumber + textString.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Scan();
        }
    }

    private void Scan()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.forward, Color.red);

        if (Physics.Raycast(scanner.transform.position, scanner.transform.forward, out hit, range)
            && hit.transform.tag == "Code")
        {
            scannedNumber++;
            scannedCount.text = scannedNumber + textString.ToString();
        }
    }
}
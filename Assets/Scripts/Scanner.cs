using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Scanner : MonoBehaviour
{
    public GameObject scanner;
    public TMP_Text scannedCount;
    public float scannedNumber;
    public float range = 1;
    public string textString;
    public InputActionReference scan;

    // Start is called before the first frame update
    private void Awake()
    {
        //Activates the InputAction
        scan.action.performed += Scan;
        scan.action.Enable();

        scannedNumber = 0;
        textString = "/5 cats";
        scannedCount.text = scannedNumber + textString.ToString();
    }

    private void Update()
    {
        //For Testing purposes, Same as Scan() but bind to left mouse button
        //if (Input.GetButton("Fire1"))
        //{
        //    Debug.Log("Triggered");
        //    RaycastHit hit;
        //    Debug.DrawRay(transform.position, Vector3.forward, Color.red, 3);

        //    if (Physics.Raycast(scanner.transform.position, scanner.transform.forward, out hit, range)
        //        && hit.transform.tag == "Code")
        //    {
        //        scannedNumber++;
        //        scannedCount.text = scannedNumber + textString.ToString();
        //    }
        //}
    }

    private void Scan(InputAction.CallbackContext context)
    {
        //Debug logging for testing
        Debug.Log("Triggered");
        Debug.DrawRay(transform.position, scanner.transform.forward, Color.red, 3);

        // Shooting raycast to check for GameObjects with the tag "Code"
        RaycastHit hit;
        if (Physics.Raycast(scanner.transform.position, scanner.transform.forward, out hit, range)
            && hit.transform.tag == "Code")
        {
            //Updates the number of scanned items and the UI text
            Debug.Log("Scanned");
            scannedNumber++;
            scannedCount.text = scannedNumber + textString.ToString();
        }
    }
}
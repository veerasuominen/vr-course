using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField]
    private Scanner scanner;

    [SerializeField]
    private GameObject gameEndScreen;

    // Start is called before the first frame update
    private void Awake()
    {
        gameEndScreen.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (scanner.scannedNumber == 5)
        {
            gameEndScreen.SetActive(true);
        }
        else { gameEndScreen.SetActive(false); }
    }
}
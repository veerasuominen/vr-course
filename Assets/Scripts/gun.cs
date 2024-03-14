using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;

    public void Shoot()
    {
        Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
    }
}
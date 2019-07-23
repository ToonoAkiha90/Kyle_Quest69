using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    float fireRate;
    float wait;

    // Use this for initialization
    void Start()
    {
        fireRate = 2f;
        wait = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        MainCannon();
    }

    void MainCannon()
    {
        if (Time.time >= wait)
        {
            Debug.Log("Boom!");
            //Instantiate(bullet, transform.position, Quaternion.identity);
            wait = Time.time + fireRate;
        }

    }
}

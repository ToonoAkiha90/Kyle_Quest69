using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    GameObject auxbullet;

    float fireRate;
    float wait;
    float wait2;

    // Use this for initialization
    void Start()
    {
        fireRate = 2f;
        wait = Time.time;
        wait2 = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        MainCannon();
        AuxCannon();
    }

    void MainCannon()
    {
        if (Time.time > wait)
        {
            Debug.Log("Boom!");
            Instantiate (bullet, transform.position, transform.rotation);
            //True max value is -1  of inputted number
            wait = Time.time + fireRate + Random.Range(0,4);
        }

    }

    void AuxCannon()
    {
        if (Time.time >= wait2)
        {
            Debug.Log("PewPew~");
            Instantiate(auxbullet, transform.position, transform.rotation);
            wait2 = Time.time + .2f;
        }
    }
}

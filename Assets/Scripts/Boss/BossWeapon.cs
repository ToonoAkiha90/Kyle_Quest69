﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

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
        if (Time.time > wait)
        {
            Debug.Log("Boom!");
            Instantiate (bullet, transform.position, transform.rotation);
            //True max value is -1  of inputted number
            wait = Time.time + fireRate + Random.Range(0,4);
        }

    }
}

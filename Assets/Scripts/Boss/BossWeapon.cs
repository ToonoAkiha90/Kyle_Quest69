using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    private float time = 0.0f;
    public float wait = 2f;

    void Bullet()
    {
        time += Time.deltaTime;
        if (time >= wait)
        {
            time = 0.0f;
            Debug.Log("Boom!");
        }
    }


}

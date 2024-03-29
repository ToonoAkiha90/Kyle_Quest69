﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float bulletSpeed;
    float spread;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    // Use this for initialization
    void Start()
    {
        bulletSpeed = 7f;
        spread = Random.Range(-.7f, .7f);

        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y + spread);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("YMAN"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }

}

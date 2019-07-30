using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuxShot : MonoBehaviour
{
    float bulletSpeed;
    float spread;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    // Use this for initialization
    void Start()
    {
        bulletSpeed = 2f;
        spread = Random.Range(-1f, 1f);

        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y + spread);
        Destroy(gameObject, 10f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("YMAN"))
        {
            Destroy(gameObject);
        }
    }

}

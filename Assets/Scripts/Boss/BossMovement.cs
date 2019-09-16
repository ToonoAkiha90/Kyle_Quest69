using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float stoppingDistance;
    [SerializeField]
    private float retreatDistance;
    float wait;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        wait = Time.time;
    }

    void Update()
    {
        //Chasing if's
        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

        else if (Vector3.Distance(transform.position, player.position) < stoppingDistance && Vector3.Distance(transform.position, player.position) > retreatDistance)
        {
            if (Time.time > wait)
            {
                Strafe();
                wait = Time.time + 2;
            }
        }

        else if (Vector3.Distance(transform.position, player.position) < retreatDistance)
        {
            //-speed does the retreating
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }

    void Strafe()
        {
        transform.position = Vector3.Lerp(transform.position, Random.insideUnitCircle * 109, speed * Time.deltaTime);
    }
}

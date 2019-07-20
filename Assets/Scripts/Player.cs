using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Unity overrides if public float
    private float speed = 5; 

    void Update()
    {
        //Movement
        float y = Input.GetAxis("Vertical") * speed;
        float x = Input.GetAxis("Horizontal") * speed;

        Vector3 move = new Vector3(x, y, 0);

        transform.position += Vector3.ClampMagnitude(move, speed) * Time.deltaTime;

        //Laser

    }
}

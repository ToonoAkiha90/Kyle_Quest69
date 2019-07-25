using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Character Stats
    //Unity overrides if public float
    private float speed = 5;
    public int Health = 4;

    //Use on trigger enter for damage detection, not collider.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Fuark.");
            
        }
    }


        
    void Update()
    {
        //Movement
        float y = Input.GetAxis("Vertical") * speed;
        float x = Input.GetAxis("Horizontal") * speed;

        Vector3 move = new Vector3(x, y, 0);

        transform.position += Vector3.ClampMagnitude(move, speed) * Time.deltaTime;
    }
}

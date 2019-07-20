using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        //Get horizontal/vertical axis
        //Mapped to arrows by default
        //Values range from -1 to 1

        float translation = Input.GetAxis("Vertical") * speed;
    }
}

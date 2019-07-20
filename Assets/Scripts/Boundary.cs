using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private Vector2 boundary;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f),
            Mathf.Clamp(transform.position.y, -4f, 1f), transform.position.z);
    }
}

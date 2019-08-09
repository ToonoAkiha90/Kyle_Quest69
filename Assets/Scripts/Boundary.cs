using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //bound.size is divided by 2 because screenbounds are relative to the sprite's center
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    void LateUpdate()
    {
        Vector3 objectPosition = transform.position;
        //screenbound position goes left to right (-screenbounds, screenbounds)
        objectPosition.x = Mathf.Clamp(objectPosition.x, -screenBounds.x + objectWidth, screenBounds.x - objectWidth);
        objectPosition.y = Mathf.Clamp(objectPosition.y, -screenBounds.y + objectHeight, screenBounds.y - objectHeight);
        transform.position = objectPosition;
    }
}

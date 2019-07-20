using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Transform FiringPoint;
    public LineRenderer linerenderer;
    public int damage = 1;

    private float time = 0.0f;
    public float wait = 1f;

  
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Laser();
        }
        else 
        {
            linerenderer.enabled = false;
        }
    }


        

    void Laser()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(FiringPoint.position, FiringPoint.right);

        if (hitInfo)
        {
            Debug.Log(hitInfo.transform.name);
            Boss enemy = hitInfo.transform.GetComponent<Boss>();
            if (enemy != null)
            {
                //Timer goes up 1 realtime sec, if it matches wait, execute code
                time += Time.deltaTime;
                if (time >= wait)
                {
                    time = 0.0f;
                    enemy.TakeDamage(damage);
                }

            }
        }

        linerenderer.SetPosition(0, FiringPoint.position);
        linerenderer.SetPosition(1, FiringPoint.position + FiringPoint.right * 100);

        linerenderer.enabled = true;
    }
}
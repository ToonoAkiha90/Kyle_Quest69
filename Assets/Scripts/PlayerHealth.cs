using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 4;

    public void TakeDamage (int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    //Particle Collision
    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Poo!");
        Health -= 1; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NastyObject : MonoBehaviour
{
    // Detect collision
    int collisionCount = 0;
    public int damage = 1;
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Get the object we collided with
        GameObject collidedWith = collision.gameObject;
        // Run the TakeDamage() function on the collided object
        if (collidedWith.GetComponent<HealthManager>() != null)
        {
            collidedWith.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
    //Detect ongoing presence in trigger area
    void OnTriggerStay2D(Collider2D collision)
    {
        //Log to console
        // Get the object we collided with
        GameObject collidedWith = collision.gameObject;
        // Run the TakeDamage() function on the collided object
        if (collidedWith.GetComponent<HealthManager>() != null)
        {
            collidedWith.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
    
}

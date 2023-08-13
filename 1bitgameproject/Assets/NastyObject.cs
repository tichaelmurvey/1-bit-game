using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NastyObject : MonoBehaviour
{
    // Detect collision
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Get the object we collided with
        GameObject collidedWith = collision.gameObject;
        // Run the TakeDamage() function on the collided object
        if (collidedWith.GetComponent<HealthManager>() != null)
        {
            collidedWith.GetComponent<HealthManager>().TakeDamage(1);
        }
    }
    //Detect ongoing presence in trigger area
    void OnTriggerStay2D(Collider2D collision)
    {
        // Get the object we collided with
        GameObject collidedWith = collision.gameObject;
        // Run the TakeDamage() function on the collided object
        if (collidedWith.GetComponent<HealthManager>() != null)
        {
            collidedWith.GetComponent<HealthManager>().TakeDamage(1);
        }
    }
    
}

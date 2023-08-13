using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int healthUp = 5;
    //Register collision with player
    void OnTriggerEnter2D(Collider2D other)
    {
        //Print collision
        Debug.Log("Collision detected with " + other.gameObject);
        //Check if player
        if (other.gameObject.CompareTag("Player"))
        {
            //check if player is on max health
            if (other.gameObject.GetComponent<HealthManager>().currentHealth == other.gameObject.GetComponent<HealthManager>().maxHealth)
            {
                //Do nothing
                return;
            }
            //Add health to player
            other.gameObject.GetComponent<HealthManager>().Heal(healthUp);
            //Destroy consumable
            Destroy(gameObject);
        }

    }
}

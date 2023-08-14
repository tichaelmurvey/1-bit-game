using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class PassiveitemAffect : MonoBehaviour
{
    public int maxHealth=0;
    public int currentHealth=0;
    public int beamAngle=0;
    public int beamLength=0;
    public int beamDamage=0;
    public float playerSpeed=0;
    
    //Detect collision with player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Update player stats with item stats
            other.gameObject.GetComponent<HealthManager>().maxHealth += maxHealth;
            other.gameObject.GetComponent<HealthManager>().currentHealth += currentHealth;
            other.gameObject.GetComponent<Player>().playerSpeed += playerSpeed;
            Light2D flashlight = other.gameObject.transform.Find("Flashlight").GetComponent<Light2D>();
            flashlight.pointLightOuterAngle += beamAngle;
            flashlight.pointLightInnerAngle += beamAngle;
            //Destroy item
            Destroy(gameObject);
        }
    }

}

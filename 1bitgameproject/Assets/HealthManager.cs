using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    //Set up player health
    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBar;
    public bool isInvincible = false;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        //Check if player is invincible
        if (isInvincible)
        {
            return;
        }
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        //Check if player is dead
        if (currentHealth <= 0)
        {
            //Kill player
            Destroy(gameObject);
        }
        //Set invincibility frames
        StartCoroutine(InvincibilityFrames());
    }
    IEnumerator InvincibilityFrames()
    {
        isInvincible = true;
        //Flash player sprite
        for (int i = 0; i < 5; i++)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(0.1f);
            GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(0.1f);
        }
        isInvincible = false;
    }
}

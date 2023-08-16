using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public int doorID;
    public bool isOpen = true;
    //Detect collision with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isOpen)
            {
                SceneManager.LoadScene("Room " + doorID.ToString());
            }
        }
    }
}

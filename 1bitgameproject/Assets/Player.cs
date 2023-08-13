using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    //Set velocity as public var
    public float playerSpeed = 1;
    public HealthManager healthManager;

    void Start()
    {
        //Disable sleep mode
        myRigidBody.sleepMode = RigidbodySleepMode2D.NeverSleep;
    }
    void Update()
    {   

        //Player health
        if (Input.GetKeyDown(KeyCode.Space))
        {
            healthManager.TakeDamage(1);
        }
        //Player movement
        Vector2 playerVelocity = new Vector2(0, 0);
        //Vertical movement
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //Set direction of movement to be up
            playerVelocity.y = 1;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            //Set direction of movement to be down
            playerVelocity.y = -1;
        } 
        //Horizontal movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            //Set direction of movement to be left
            playerVelocity.x = -1;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            //Set direction of movement to be right
            playerVelocity.x = 1;
        } 
        //Normalise velocity
        playerVelocity.Normalize();
        //Multiply velocity by speed
        playerVelocity *= playerSpeed;
        //Assign velocity to rigidbody
        myRigidBody.velocity = playerVelocity;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    //Set velocity as public var
    public float playerSpeed = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //Set direction of movement to be up
            myRigidBody.velocity = new Vector2(0, 100);
            
        } else {
            //Set direction to none
            myRigidBody.velocity = new Vector2(0, 0);
        }
    }
}

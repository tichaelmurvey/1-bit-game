using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(mouse.x - transform.position.x, mouse.y - transform.position.y);
        //Rotate this object to face the mouse
        transform.up = direction;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
   //Hide initially
    void Start()
    {
         gameObject.SetActive(false);
    }
    public void Show()
    {
        //Show death screen
        gameObject.SetActive(true);
    }
}

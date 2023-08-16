using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadLevel("Room");
        }
    }

    public void LoadLevel(string LevelName)
    {
        //Print the name of the level that is being loaded
        Debug.Log("Loading " + LevelName);
        SceneManager.LoadScene(LevelName);
    }
}

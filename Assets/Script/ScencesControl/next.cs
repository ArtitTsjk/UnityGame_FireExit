using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public KeyCode Next;
    public string levelInput = "";


    void Update()
    {
        if (Input.GetKeyDown(Next))
        {

            levelToLoad("");
        }
    }
    public void levelToLoad(string level)
    {
        level = levelInput;
        SceneManager.LoadScene(level);
    }
}

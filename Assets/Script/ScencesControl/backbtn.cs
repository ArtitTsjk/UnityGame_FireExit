using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backbtn : MonoBehaviour
{
    public KeyCode Back;

    public string levelInput = "";

    void Update()
    {
        if (Input.GetKeyDown(Back))
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
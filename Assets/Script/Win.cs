using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public string levelInput = "";
    // Start is called before the first frame update

    public void Replay()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1f;
    }

    public void next()
    {       
        levelToLoad("");
        Time.timeScale = 1f;
        PlayerMovement.runSpeed = 40f;
    }

    public void levelToLoad(string level)
    {
        level = levelInput;
        SceneManager.LoadScene(level);
    }
}

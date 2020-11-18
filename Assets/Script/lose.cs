using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lose : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Replay()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1f;
    }
    public void LoadMenu()
    {
        SoundManager.PlaySound("btnMENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Openning");

    }

    public void StageSelect()
    {
        SoundManager.PlaySound("btnMENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("stageselect");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

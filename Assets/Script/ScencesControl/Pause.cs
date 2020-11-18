using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;
    public GameObject HTP;

    private void Start()
    {
        HTP.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPause)
            {
                Resume();
                
            }
            else
            {
                if (!phone.OnPhone && !Guide1.OnGuide && !Guide.OnGuide)
                {
                    GamePause();
                    SoundManager.PlaySound("btnMENU");
                }
            }
        }
    }

    public void Resume()
    {
        SoundManager.PlaySound("btnMENU");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    void GamePause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu()
    {
        SoundManager.PlaySound("btnMENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Openning");
        GameIsPause = false;
    }

    public void StageSelect()
    {
        SoundManager.PlaySound("btnMENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("stageselect");
        GameIsPause = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void H2P()
    {
        SoundManager.PlaySound("btnMENU");
        HTP.SetActive(true);
        GameIsPause = false;
    }
    public void menu2()
    {
        SoundManager.PlaySound("btnMENU");
        HTP.SetActive(false);
        GameIsPause = false;
    }
}

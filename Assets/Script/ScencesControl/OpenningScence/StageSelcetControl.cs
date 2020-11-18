using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StageSelcetControl : MonoBehaviour
{
    public Button stage2btn, stage3btn, stage4btn, stage5btn, stage6btn, stage7btn, stage8btn, stage9btn, stage10btn;
    int levelPassed;

    // Use this for initialization
    void Start()
    {
        Debug.Log(levelPassed);
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        stage2btn.interactable = false;
        stage3btn.interactable = false;
        stage4btn.interactable = false;
        stage5btn.interactable = false;
        stage6btn.interactable = false;
        stage7btn.interactable = false;
        stage8btn.interactable = false;
        stage9btn.interactable = false;
        stage10btn.interactable = false;

        switch (levelPassed)
        {
            case 1:
                stage2btn.interactable = true;
                break;
            case 2:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                break;
            case 3:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                break;
            case 4:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                break;
            case 5:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                break;
            case 6:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                break;
            case 7:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                break;
            case 8:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                stage9btn.interactable = true;
                break;
            case 9:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                stage9btn.interactable = true;
                stage10btn.interactable = true;
                break;
            case 10:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                stage9btn.interactable = true;
                stage10btn.interactable = true;
                break;
            case 11:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                stage9btn.interactable = true;
                stage10btn.interactable = true;
                break;
            case 12:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                stage9btn.interactable = true;
                stage10btn.interactable = true;
                break;
            case 32:
                stage2btn.interactable = true;
                stage3btn.interactable = true;
                stage4btn.interactable = true;
                stage5btn.interactable = true;
                stage6btn.interactable = true;
                stage7btn.interactable = true;
                stage8btn.interactable = true;
                stage9btn.interactable = true;
                stage10btn.interactable = true;
                break;

        }
    }

    public void levelToLoad(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        stage2btn.interactable = false;
        stage3btn.interactable = false;
        stage4btn.interactable = false;
        stage5btn.interactable = false;
        stage6btn.interactable = false;
        stage7btn.interactable = false;
        stage8btn.interactable = false;
        stage9btn.interactable = false;
        stage10btn.interactable = false;        

        PlayerPrefs.DeleteAll();
    }
    public void LoadMenu()
    {
        SoundManager.PlaySound("btnMENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Openning");
    }

}

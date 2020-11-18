using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OP : MonoBehaviour
{
    public GameObject OPMenuUI;
    public void PlayBtn()
    {
        SoundManager.PlaySound("btnMENU");
        UnityEngine.SceneManagement.SceneManager.LoadScene("prestage1");
        StartCoroutine(Delay());

    }
    public void QuitGame()
    {
        SoundManager.PlaySound("btnMENU");
        
        Application.Quit();
    }
    public void StageSelect()
    {
        SoundManager.PlaySound("btnMENU");
        StartCoroutine(Delay());
        SceneManager.LoadScene("stageselect");

    }

    public void H2P()
    {
        SoundManager.PlaySound("btnMENU");
        StartCoroutine(Delay());
        SceneManager.LoadScene("H2P");

    }

    public void Credit()
    {
        SoundManager.PlaySound("btnMENU");
        StartCoroutine(Delay());
        SceneManager.LoadScene("Credit");

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phoneNum : MonoBehaviour
{
    public string levelInput = "";
    public GameObject NOOInput;
    public GameObject OTThInput;
    public GameObject OOFZInput;
    public GameObject Phone;
    public void ONN()
    {
        levelToLoad("");
        PlayerMovement.instance.youWin();
        phone.OnPhone = false;
    }

    public void OOFZ()
    {
        OOFZInput.SetActive(true);
        if (Input.GetKey(KeyCode.Space))
        {
            OOFZInput.SetActive(false);
        }
    }

    public void OTTh()
    {
        OTThInput.SetActive(true);
        if (Input.GetKey(KeyCode.Space))
        {
            OTThInput.SetActive(false);
        }
    }
    public void NOO()
    {
        NOOInput.SetActive(true);
        if (Input.GetKey(KeyCode.Space))
        {
            NOOInput.SetActive(false);
        }
    }
    public void levelToLoad(string level)
    {
        level = levelInput;
        SceneManager.LoadScene(level);
    }

    private void Update()
    {

    }
}

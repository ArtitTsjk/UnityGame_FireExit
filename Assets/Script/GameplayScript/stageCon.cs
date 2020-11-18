using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stageCon : MonoBehaviour
{

    public static int TimeLeft;
    public int TimeInput;
    
    public GameObject loseActive;
    public GameObject UIActive;

    void Start()
    {
        TimeLeftInput(0);
        TimeLeft = TimeInput;
        StartCounting();
        loseActive.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Count()
    {
        if (TimeLeft > 0)
        {
            TimeLeft--;
        }
        else
        {
            loseActive.SetActive(true);
            UIActive.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    void StartCounting()
    {
        InvokeRepeating("Count", 0, 1);
    }


    IEnumerator DelayDead()
    {
        yield return new WaitForSeconds(1f);
        loseActive.SetActive(true);
        UIActive.SetActive(false);
        Time.timeScale = 0f;
    }

    private void FixedUpdate()
    {

        if (PlayerMovement.life <= 0)
        {
            StartCoroutine(DelayDead());
            
        }
        if (TimeLeft < 30)
        {

        }
    }

    public void TimeLeftInput(int TimeLeftInput)
    {
        TimeLeftInput = TimeInput;
    }

}

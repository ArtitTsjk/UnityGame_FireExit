using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    public GameObject GuideAppear;
    public static bool OnGuide;

    void Start()
    {
        GuideAppear.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            OnGuide = true;
            PlayerMovement.MoveSound.Stop();
            PlayerMovement.runSpeed = 0;
            if (OnGuide)
            {
                GuideAppear.SetActive(true);
                Time.timeScale = 0f;                
            }
        }
    }
}


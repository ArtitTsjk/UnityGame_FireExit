using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide1 : MonoBehaviour
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
            
            if (OnGuide)
            {
                StartCoroutine(TimeDelay());
                PlayerMovement.IsMoving = false;
            }
        }
    }
    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.7f);
        GuideAppear.SetActive(true);
        Time.timeScale = 0f;
    }
}
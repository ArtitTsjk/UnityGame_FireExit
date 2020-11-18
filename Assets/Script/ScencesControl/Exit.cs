using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exit : MonoBehaviour
{
    public GameObject winActive;

    private void Start()
    {
        winActive.SetActive(false);
        PlayerMovement.instance.youWin();
    }

    void OnTriggerEnter2D(Collider2D Exit)
    {
        if (Exit.gameObject.tag == "Player")
        {
            PlayerMovement.MoveSound.Stop();
            PlayerMovement.runSpeed = 0f;
            winActive.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}

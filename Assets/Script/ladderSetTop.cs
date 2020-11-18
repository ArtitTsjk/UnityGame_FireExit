using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderSetTop : MonoBehaviour
{
    public GameObject floortarget;

    // Use this for initialization
    void Start()
    {
        floortarget.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                floortarget.SetActive(false);
            }
            else if (Input.GetButtonDown("Horizontal"))
            {
                floortarget.SetActive(true);
            }

        }
    }
}

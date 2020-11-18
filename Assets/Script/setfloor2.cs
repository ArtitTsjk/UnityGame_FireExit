using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setfloor2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject realstair;
    public GameObject floortarget;
    void Start()
    {
        
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetButton("Horizontal"))
            {
                floortarget.SetActive(false);
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetButton("Horizontal"))
            {
                floortarget.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            realstair.SetActive(true);
        }
    }

}

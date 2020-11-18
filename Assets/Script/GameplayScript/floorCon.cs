using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorCon : MonoBehaviour
{
    public GameObject SetActiveFloor;

    // Use this for initialization
    void Start()
    {
        SetActiveFloor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetButton("Horizontal"))
            {
                SetActiveFloor.SetActive(false);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                SetActiveFloor.SetActive(false);
            }
            else if (Input.GetButton("Horizontal"))
            {
                SetActiveFloor.SetActive(true);
            }
        }
    
    }

}

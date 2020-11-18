using UnityEngine;
using System.Collections;

public class StairControl1 : MonoBehaviour
{

    public float speed = 6;
    public GameObject realstair;

    // Use this for initialization
    void Start()
    {
        realstair.SetActive(false);
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
                realstair.SetActive(true);
            }
            else if (Input.GetKeyUp(KeyCode.UpArrow) && Input.GetButtonUp("Horizontal"))
            {
                realstair.SetActive(false);
            }

        }
    }
}


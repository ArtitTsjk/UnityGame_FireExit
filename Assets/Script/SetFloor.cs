using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFloor : MonoBehaviour
{
    [SerializeField] public GameObject floortarget;

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

}

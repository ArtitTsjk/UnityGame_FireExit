using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour, IUseable
{
    [SerializeField]    public GameObject floortarget;
    public void Use()
    {
        if (PlayerMovement.Instance.OnLadder)
        {
            Debug.Log("อินสแตนออนเลดเดอร์ละสัด");
            UseLadder(false, 4, 0, 1);
        }
        else
        {
            
            Debug.Log("ไม่อินสแตนออนเลดเดอร์ละสัด");
            UseLadder(true, 0, 1, 0);
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        UseLadder(false, 4, 0, 1);
        
        Debug.Log("ออกละนะสัด");
        floortarget.SetActive(true);

    }

    void Start()
    {
        floortarget.SetActive(true);
    }

    private void UseLadder(bool onLadder, int gravityScale, int layerWeight, int animSpeed)
    {
        PlayerMovement.Instance.OnLadder = onLadder;
        PlayerMovement.Instance.rb.gravityScale = gravityScale;
        PlayerMovement.Instance.animator.SetLayerWeight(1, layerWeight);
        PlayerMovement.Instance.animator.speed = animSpeed;

    }


    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                floortarget.SetActive(false);
            }

        }
    }
}

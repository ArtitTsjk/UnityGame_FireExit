using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair : MonoBehaviour, IUseable
{
    [SerializeField]
    private Collider2D platformCollider;
    public GameObject floortarget;
    public void Use()
    {
        if (PlayerMovement.Instance.OnLadder)
        {
            Debug.Log("อินสแตนออนเลดเดอร์ละสัด");
            UseStair(false, 4, 0, 1);
        }
        else
        {

            Debug.Log("ไม่อินสแตนออนเลดเดอร์ละสัด");
            UseStair(true, 0, 2, 0);
            Physics2D.IgnoreCollision(PlayerMovement.Instance.GetComponent<Collider2D>(), platformCollider, true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        UseStair(false, 4, 0, 1);
        Physics2D.IgnoreCollision(PlayerMovement.Instance.GetComponent<Collider2D>(), platformCollider, true);
        Debug.Log("ออกละนะสัด");
        floortarget.SetActive(true);

    }

    void Start()
    {
        floortarget.SetActive(true);
    }

    private void UseStair(bool onLadder, int gravityScale, int layerWeight, int animSpeed)
    {
        PlayerMovement.Instance.OnLadder = onLadder;
        PlayerMovement.Instance.rb.gravityScale = gravityScale;
        PlayerMovement.Instance.animator.SetLayerWeight(2 , layerWeight);
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

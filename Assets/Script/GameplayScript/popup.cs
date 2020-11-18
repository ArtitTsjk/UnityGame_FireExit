using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject GuideAppear;
    // Start is called before the first frame update
    void Start()
    {
        GuideAppear.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GuideAppear.SetActive(true);
            SoundManager.PlaySound("btn3");
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GuideAppear.SetActive(false);
            
        }
    }



}

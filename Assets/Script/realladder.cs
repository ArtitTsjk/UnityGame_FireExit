using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realladder : MonoBehaviour
{
    public GameObject ladderself;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerExit2D(Collider2D other)
    {
        ladderself.SetActive(false);
    }
}

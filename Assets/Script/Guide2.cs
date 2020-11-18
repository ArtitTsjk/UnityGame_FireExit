using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide2 : MonoBehaviour
{
    public GameObject GuideAppear;
    public KeyCode Close;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Close))
        {
            Time.timeScale = 1f;
            StartCoroutine(TimeDelay());
            PlayerMovement.runSpeed = 40f;
        }
    }
    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.1f);
        GuideAppear.SetActive(false);
        Destroy(gameObject);      
        Guide1.OnGuide = false;
        Guide.OnGuide = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class H2P : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        SoundManager.PlaySound("btnMENU");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Openning");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class exitdoor : MonoBehaviour
{
    public string levelInput = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Exit)
    {
        if (Exit.gameObject.tag == "Player")
        {
            levelToLoad("");
        }
    }
    public void levelToLoad(string level)
    {
        level = levelInput;
        SceneManager.LoadScene(level);
    }
}

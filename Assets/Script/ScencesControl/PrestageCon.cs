using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrestageCon : MonoBehaviour
{
    public KeyCode PressSpace;
    public string ScenesInput = "";
    public int TimeInput;
    public static int TimeLeft;


    // Start is called before the first frame update
    void Start()
    {
        TimeLeftInput(0);
        TimeLeft = TimeInput;
        StartCounting();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft <= 0)
        {
            ScenesLoadto("");
        }
    }
    public void ScenesLoadto(string Scenes)
    {
        Scenes = ScenesInput;
        SceneManager.LoadScene(Scenes);
    }

    public void TimeLeftInput(int TimeLeftInput)
    {
        TimeLeftInput = TimeInput;
    }
    void StartCounting()
    {
        InvokeRepeating("Count", 0, 1);
    }
    public void Count()
    {
        if (TimeLeft > 0)
        {
            TimeLeft--;
        }
    }
    private void FixedUpdate()
    {
        if (TimeLeft < 10)
        {
            if (Input.GetKeyDown(PressSpace))
            {
                ScenesLoadto("");
            }
        }
    }
}

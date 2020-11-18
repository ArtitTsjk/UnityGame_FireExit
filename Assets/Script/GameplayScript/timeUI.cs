using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeUI : MonoBehaviour
{

    Text t;
    void Start ()
    {
        t = GetComponent<Text>();
    }

    void Update ()
    {
        t.text = "" + stageCon.TimeLeft;
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifetextUI : MonoBehaviour
{

    Text t;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        t.text = "" + PlayerMovement.life;
       
    }
}

﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class scoreManager : MonoBehaviour {

    public static int score;
    Text text;

	void Awake () 
    {
        text = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {

        text.text = "Score: " + score;
	}
}

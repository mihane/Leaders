﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TsuminiScript : MonoBehaviour {
	public static int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score.ToString ();
	}

	void OnTriggerEnter(Collider other){
		score += 10;
	}
}

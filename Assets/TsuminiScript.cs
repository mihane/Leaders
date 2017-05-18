using System.Collections;
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
		if(other.tag == "Box")
			score += 10;
		if (other.tag == "SoccerBall")
			score += 20;
		if (other.tag == "TV")
			score += 30;
		if (other.tag == "TrashBin")
			score += 40;
			
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Box")
			score -= 10;
		if (other.tag == "SoccerBall")
			score -= 20;
		if (other.tag == "TV")
			score -= 30;
		if (other.tag == "TrashBin")
			score -= 40;
	}
}

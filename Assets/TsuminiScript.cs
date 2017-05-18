using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TsuminiScript : MonoBehaviour {
	public static int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		//scoreText.text = "Score : " + score.ToString ();
		scoreText.text = score.ToString ();
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Box")
			score += 1000;
		if (other.tag == "SoccerBall")
			score += 2000;
		if (other.tag == "TV")
			score += 3000;
		if (other.tag == "TrashBin")
			score += 4000;
			
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Box")
			score -= 1000;
		if (other.tag == "SoccerBall")
			score -= 2000;
		if (other.tag == "TV")
			score -= 3000;
		if (other.tag == "TrashBin")
			score -= 4000;
	}
}

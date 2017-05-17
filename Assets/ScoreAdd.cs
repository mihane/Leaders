using UnityEngine;
using System.Collections;

public class ScroeAdd : MonoBehaviour {

	private int score = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void ScoreAdd(){
		print("Score= "+ ++score);

	}
}


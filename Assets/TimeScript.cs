using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public Text time;
	public float timeLimit = 30.0f;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		timeLimit -= Time.deltaTime;
		time.text = "Time : " + timeLimit.ToString ("f2");
		if (timeLimit <= 0.0)
			time.text = "Automatic Operation";
		if (timeLimit <= -30.0)
			gameObject.SetActive (false);
			
	}
}

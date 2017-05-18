using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GOTOTITLE(){
		SceneManager.LoadScene ("Title");
	}

	public void GOTOMAIN(){
		SceneManager.LoadScene ("Main");

	}

	public void GAMESTART(){
		SceneManager.LoadScene ("Main");

	}

	public void HOWTOPLAY(){
		SceneManager.LoadScene ("HowToPlay");

	}

	public void HOWTOPLAY_NEXT(){
		SceneManager.LoadScene ("HowToPlay_2");

	}

	public void HOWTOPLAY_2_NEXT(){
		SceneManager.LoadScene ("HowToPlay_3");

	}

	public void HOWTOPLAY_2_PREV(){
		SceneManager.LoadScene ("HowToPlay");

	}
	public void HOWTOPLAY_3_NEXT(){
		SceneManager.LoadScene ("HowToPlay_4");

	}

	public void HOWTOPLAY_3_PREV(){
		SceneManager.LoadScene ("HowToPlay_2");

	}

	public void HOWTOPLAY_4_NEXT(){
		SceneManager.LoadScene ("HowToPlay_5");

	}

	public void HOWTOPLAY_4_PREV(){
		SceneManager.LoadScene ("HowToPlay_3");

	}

	public void HOWTOPLAY_5_GAMESTART(){
		SceneManager.LoadScene ("Main");

	}

	public void HOWTOPLAY_5_PREV(){
		SceneManager.LoadScene ("HowToPlay_4");

	}
}

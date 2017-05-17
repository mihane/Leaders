using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsuminiController : MonoBehaviour {
	public GameObject box;
	public GameObject ball;
	public GameObject tv;
	public GameObject trashbin;

		
	void    OnTriggerStay(Collider col){

		//SendMessage(“関数名”) で対象が持っているスクリプトが持っている関数を呼び出すことができる  
		if(col.gameObject == box){ 
			col.gameObject.SendMessage ("ScoreAdd", 10);
		}
		if (col.gameObject == ball) { 
			col.gameObject.SendMessage ("ScoreAdd", 20);
		}
		if (col.gameObject == tv) { 
			col.gameObject.SendMessage ("ScoreAdd", 30);
		}
		if (col.gameObject == trashbin) { 
			col.gameObject.SendMessage ("ScoreAdd", 40);
		}
			
	}
}

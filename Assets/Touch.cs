using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
	// rayが届く範囲
	public float distance = 100f;

	public GameObject[] tsumini = new GameObject[5];

	public GameObject cube;

	private Vector3 clickPosition;

	public int hantei;

	void Update () {
		// 左クリックを取得
		if (Input.GetMouseButtonDown(0)) {
			// クリックしたスクリーン座標をrayに変換
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// Rayの当たったオブジェクトの情報を格納する
			RaycastHit hit = new RaycastHit();
			// オブジェクトにrayが当たった時
			if (Physics.Raycast(ray, out hit, distance)) {
				// rayが当たったオブジェクトの名前を取得
				string objectName = hit.collider.gameObject.name;
				Debug.Log(objectName);

				clickPosition = Input.mousePosition;

				clickPosition.z = 5f;

				Instantiate (tsumini[hantei], Camera.main.ScreenToWorldPoint (clickPosition), cube.transform.rotation);
			}
		}
	}

	public void Box (){
		hantei = 0;
	}

	public void ball (){
		hantei = 1;
	}

	public void TV (){
		hantei = 2;
	}

	public void Trashbin (){
		hantei = 3;
	}
}

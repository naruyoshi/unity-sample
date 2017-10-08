using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

// sample
public class Sample : MonoBehaviour {

	Rigidbody2D rigid2D;
	float count;
	string dateTimeStr;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 日時情報取得
		//dateTimeStr = System.DateTime.Now.ToString ();
		//Debug.Log (dateTimeStr);

		// time.deltatime sample
		// time.deltaTimeで1フレーム辺りの時間を取得
		count += Time.deltaTime;
		//Debug.Log (count);

		// 1secをカウント
		if (count >= 1.0f) {
			dateTimeStr = System.DateTime.Now.ToString ();
			Debug.Log (dateTimeStr);
			Debug.Log ("1sec" + count);
			count = 0.0f;
		}



	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stones : MonoBehaviour {
	public int score;
	public int schet;

	// Use this for initialization
	void Start () {
		schet = 0;
	}
	//public void OnClick(){
	//	score++;
	//	schet++;
	//	if (schet == 3) {
			//this.gameObject.SetActive();
	//		Destroy(this.gameObject);
	//		schet = 0;
	//	}
	//}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)) {
			score++;
			schet++;
			if (schet == 3) {
				//this.gameObject.SetActive();
				Destroy(this.gameObject);
				schet = 0;
			}
		}
	}

	void OnGUI(){
		GUI.Box (new Rect(0, 0, 70, 20), "Score: " + score);
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}

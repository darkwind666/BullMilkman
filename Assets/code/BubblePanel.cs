using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePanel : MonoBehaviour {
	public int score;
	public GameObject[] prefab = new GameObject[1];
	public List<GameObject>[] bubbles = new List<GameObject>[1];
	public float speed = 40f;
	public GameObject Cat;


	void Start (){
		//	score = 0;
		bubbles[0] = new List<GameObject>();
		score = 0;
	}

	void Update (){
		int sw = Screen.width;
		int sh = Screen.height;
		int count = bubbles [0].Count;
		List<GameObject> bub = bubbles [0];
		bool nadAdd = false;
		if (count > 0) {
			for (int i = 0; i < count; i++) {
				switch (Random.Range (0, 1)) {
				case 0:
					bub [i].transform.Translate (Vector2.right * Time.deltaTime * -speed);
					break;
				case 1:
					bub [i].transform.Translate (Vector2.left * Time.deltaTime * speed);
					break;
				//case 2:
				//	bub [i].transform.Translate (Vector2.left * Time.deltaTime * speed);
				}
			}
		} else
			nadAdd = true;
		if(nadAdd){ 
			//float between = Random.Range (10, 30);
			//Vector3 pos = new Vector3 (sw + Random.Range(0, 50), sh/2+Random.Range(-30,30), 0);
			//pos.y += Random.Range (20, 50) / 2;
			//GameObject bub = Instantiate<GameObject> (prefab);
			//bub.transform.position = Camera.main.ScreenToWorldPoint(pos)+Vector3.forward/*1f*Cat.position.z*//*Vector3.right*/;
			/*bub = GameObject.AddComponent (bubbles)*/;
		}
	}

	public void OnClick(){
		score++;
		//if (GameObject.name == "stone") {
		
		//}
	}

	void OnGUI(){
		GUI.Box (new Rect(0, 0, 70, 20), "Score: " + score);
	}
}

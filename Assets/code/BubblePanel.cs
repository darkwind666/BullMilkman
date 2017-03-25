using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePanel : MonoBehaviour {
	public int score;
	public GameObject prefab;
	//public List<GameObject>[] cats = new List<GameObject>[1];
	public float speed = 40f;
	public Transform bull;

	int respawnIntervalTime = 100;
	int respawnIndex;

	//public GameObject Cat;


	void Start (){
		respawnIndex = 0;

	}

	void Update (){
		int sw = Screen.width;
		int sh = Screen.height;
		float between = Random.Range (1, 5);
		Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3 (0 + Random.Range(-7, 7), 0+Random.Range(-7,7), bull.position.z));
		pos.y += between / 2;

		respawnIndex++;

		if (respawnIndex >= respawnIntervalTime) {
			respawnIndex = 0;
			GameObject prefabCat = Instantiate (prefab, pos, transform.rotation);
			cats cat = prefabCat.GetComponent<cats> ();
			cat.SetBull (bull.gameObject);
			prefabCat.transform.parent = this.transform;
		}

			//GameObject prefab = Instantiate<GameObject> (catty[0]);
			//prefab.transform.position = Camera.main.ScreenToWorldPoint(pos)/*+Vector3.forward* cat.position.z/*1f*Cat.position.z*//*Vector3.right*/;
			//cats[0].Add(prefab);
		//}
	}

	public void OnClick(){
		//score++;
		//if (GameObject.name == "stone") {
		
		//}
	}

	void OnGUI(){
		GUI.Box (new Rect(0, 0, 70, 20), "Score: " + score);
	}
}

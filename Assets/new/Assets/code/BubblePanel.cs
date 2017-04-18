using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BubblePanel : MonoBehaviour {
	public GameObject prefab;
	public float speed = 40f;
	public Transform bull;
	private string sceneReturnName;

	int respawnIntervalTime;
	int respawnIndex;


	void Start (){
		sceneReturnName = SceneManager.GetActiveScene ().name;
		if (sceneReturnName == "level1") {
			respawnIndex = 10;
		} else {
			respawnIndex = 20;
		}
		if (sceneReturnName == "level2") {
			respawnIntervalTime = 60;
		} else {
			respawnIntervalTime = 70;
		}

	}

	void Update (){
		int sw = Screen.width;
		int sh = Screen.height;
		float between = Random.Range (1, 5);
			Vector3 pos = Camera.main.ViewportToWorldPoint (new Vector3 (0 + Random.Range (4, 7), 0 + Random.Range (-7, 7), bull.position.z));
			pos.y += between / 2;

		respawnIndex++;

		if (respawnIndex >= respawnIntervalTime) {
			respawnIndex = 0;
			GameObject prefabCat = Instantiate (prefab, pos, transform.rotation);
			cats cat = prefabCat.GetComponent<cats> ();
			cat.SetBull (bull.gameObject);
			prefabCat.transform.parent = this.transform;
			//GameObject prefabStone = Instantiate (prefabS, posS, transform.rotation);
		}
			
	}
		
}

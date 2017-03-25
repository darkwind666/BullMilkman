using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cam : MonoBehaviour {
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	Camera camer;
	public Image progress;

	void Start() {
		camer = GetComponent<Camera> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (target)
		{
			Vector3 point = camer.WorldToViewportPoint(new Vector3(target.position.x, target.position.y+0.75f,target.position.z));
			Vector3 delta = new Vector3 (target.position.x, target.position.y + 0.75f, target.position.z) - camer.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;


			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			progress.fillAmount -=  Time.deltaTime;
		}

	}
	//public GameObject prefab;
	//public List<GameObject>[] bubbles = new List<GameObject>[1];


	//void Start (){
	//	score = 0;
	//	bubbles[0] = new List<GameObject>();
	//}

	//void Update (){
	//	int sw = Screen.width;
	//	int sh = Screen.height;
	//	int count = bubbles [0].Count;
	//	List<GameObject> bub = bubbles [0];
	//	if (count > 0) {
	//		bubbles [0].transform.Translate (Vector2.right*Time.deltaTime*-speed);
	//	}
	//}

	//void OnGUI(){
	//	GUI.Box (new Rect(0, 0, 70, 20), "Score: " + score);
	//}
}

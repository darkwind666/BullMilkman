using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cats : MonoBehaviour {
	public int score;
	public int schet;
	public Rigidbody2D catBody;
	public float speed = 30f;
	private GameObject bull;
	public Vector3 ourPos;
	public Vector3 nextPos;
	public float min = -1f;
	//bool isMove = false;

	// Use this for initialization
	void Start () {
		schet = 0;
		catBody = GetComponent<Rigidbody2D>();
		//isMove = false;
		ourPos = transform.position;
		nextPos = transform.position;
	}

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, bull.transform.position, Time.deltaTime * speed*0.1f);


		//if (true)
		//	return;

		//isMove = true;
		//RaycastHit hit;
		//Ray ray = Camera.main.ScreenPointToRay (bull.transform.position);
		//if (Physics.Raycast (ray, out hit)) {
		//	nextPos = hit.point;
		//	Debug.Log ("our = " + ourPos);
		//	Debug.Log ("next = " + nextPos);
		//} else {
		//	Debug.Log ("not working!");
		//}
		//if (ourPos != nextPos) {
		//	Debug.Log ("hear");
		//	transform.position = Vector3.MoveTowards (transform.position, nextPos, Time.deltaTime * speed);
			//catBody.velocity = nextPos*speed*Time.deltaTime;/*new Vector3 (transform.position, nextPos, Time.deltaTime * speed);*/
		//} else {
		//	Debug.Log ("test");
			//isMove = false;
		//}		//catBody.velocity = new Vector2 (-speed * Time.deltaTime, catBody.velocity.y);

	}
	// Use this for initialization
	void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)) {
			score++;
			schet++;
			if (schet == 3) {
				//this.gameObject.SetActive();
				//Destroy(this.gameObject);
				schet = 0;
				speed = -30f;
			}
		}
	}

	//void OnGUI(){
	//	GUI.Box (new Rect(0, 0, 70, 20), "Score: " + score);
	//}

	public void SetBull(GameObject bull) {
		this.bull = bull;
	}
}

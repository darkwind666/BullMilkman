using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour {
	public Rigidbody2D catBody;
	public float speed = 20f;
	//public int score;
	//public float move;

	void Start () {
		catBody = GetComponent<Rigidbody2D>();
		//score = 0;
	}

	void FixedUpdate () {
		//move = Input.GetAxis ("Horisontal");
		//catBody.velocity = new Vector2 (speed * move, catBody.velocity.y);
		//catBody.AddForce(new Vector2 (1*Time.deltaTime, 0));
		catBody.velocity = new Vector2 (speed * Time.deltaTime, catBody.velocity.y);
	}
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.name == "podushka") {
			
		}
	}
	//void OnGUI(){
	//	GUI.Box (new Rect(0, 0, 70, 20), "Score: " + score);
	//}
}

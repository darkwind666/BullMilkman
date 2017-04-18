using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour {

	public Rigidbody2D catBody;
	public float speed = 40f;
	public int lifeCheck = 5;
	public Texture2D life;


	void Start () {
		catBody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		catBody.velocity = new Vector2 (speed * Time.deltaTime, catBody.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "stones") {
			if (lifeCheck >= 1) {
				--lifeCheck;
			} else {
				SceneManager.LoadScene ("die");
			}
		}
		if (col.gameObject.name == "cat2(Clone)") {
			if (lifeCheck >= 1) {
				--lifeCheck;
			} else {
				SceneManager.LoadScene ("die");
			}
		}
		if (col.gameObject.name == "endLevel") {
			
				SceneManager.LoadScene ("level2");
		}
	}


	void OnGUI(){
		if (lifeCheck >= 1) {
			GUI.DrawTexture (new Rect (0, 0, 70, 90), life);
			if (lifeCheck >= 2) {
				GUI.DrawTexture (new Rect (70, 0, 70, 90), life);
				if (lifeCheck >= 3) {
					GUI.DrawTexture (new Rect (140, 0, 70, 90), life);
					if (lifeCheck >= 4) {
						GUI.DrawTexture (new Rect (210, 0, 70, 90), life);
						if (lifeCheck >= 5) {
							GUI.DrawTexture (new Rect (280, 0, 70, 90), life);
						}
					}
				}
			}
		}
	}
}

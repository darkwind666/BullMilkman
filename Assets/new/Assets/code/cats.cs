using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cats : MonoBehaviour {
	public Rigidbody2D catBody;
	public float speed = 10f;
	private GameObject bull;
	public Vector3 ourPos;
	public Vector3 nextPos;
	public float min = -1f;
	public Sprite[] sprites = new Sprite[2];
	public GameObject catsDecant;
	public Collider2D end;


	void Start () {
		catBody = GetComponent<Rigidbody2D>();
		ourPos = transform.position;
		nextPos = transform.position;
	}

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, bull.transform.position, Time.deltaTime * speed*0.07f);

	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)) {
				speed = -30f;
				catsDecant.GetComponent<SpriteRenderer> ().sprite = sprites [1];
			end = catsDecant.GetComponent<Collider2D>();
			end.enabled = true;
		}
	}
		

	public void SetBull(GameObject bull) {
		this.bull = bull;
	}
}

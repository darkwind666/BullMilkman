using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour {
	//public GameObject cloud;
	public float speed = 20f;
	public Rigidbody2D cloudB;
	//public Vector3 posC;

	// Use this for initialization
	void Start () {
		//posC = transform.position;
		cloudB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		cloudB.velocity = new Vector2 (-speed * Time.deltaTime, cloudB.velocity.y);/* = new Vector3 ((transform.position.x + Random.Range(-4,4))*speed*Time.deltaTime, (transform.position.y+Random.Range(-4,4))*speed*Time.deltaTime, transform.position.z);*/
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cam : MonoBehaviour {
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	Camera camer;
	//public Image progress;

	void Start() {
		camer = GetComponent<Camera> ();
	}
		
	void Update () 
	{
		if (target)
		{
			Vector3 point = camer.WorldToViewportPoint(new Vector3(target.position.x, target.position.y+0.75f,target.position.z));
			Vector3 delta = new Vector3 (target.position.x+2, target.position.y + 0.75f, target.position.z) - camer.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;


			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			//progress.fillAmount -=  Time.deltaTime;
		}

	}
}

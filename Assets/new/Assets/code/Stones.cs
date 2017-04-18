using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stones : MonoBehaviour {

	public GameObject brevno;
	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)) {
			anim.SetBool ("explode", true);
		}
	}

	public void DestroyStone() {
		Destroy (this.gameObject);	
	}
}

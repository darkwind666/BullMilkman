using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startSCript : MonoBehaviour {
	public GameObject buttomMilkman;
	public Sprite[] sprites = new Sprite[2];


	void OnMouseEnter(){
		buttomMilkman.GetComponent<SpriteRenderer> ().sprite = sprites [1];
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("level1");
		}
	}

	void OnMouseExit(){
		buttomMilkman.GetComponent<SpriteRenderer> ().sprite = sprites [0];
	}
}

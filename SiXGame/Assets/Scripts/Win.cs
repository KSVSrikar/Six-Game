using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {

	public Text txt1;

	// Use this for initialization
	void Start () {
		txt1.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D(Collision2D other){
		if(other.gameObject.tag == "Player" && other.relativeVelocity == Vector2.zero){
			txt1.text = "CONGRATS!!\nYOU WIN";
		}
	}

}

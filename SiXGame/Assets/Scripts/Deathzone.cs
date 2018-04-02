using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Deathzone : MonoBehaviour {

	public Text txt;

	// Use this for initialization
	void Start () {
		txt.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			txt.text = "YOU LOSE";
		}
		Destroy (other.gameObject);
	}

}


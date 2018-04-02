using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camerafollow : MonoBehaviour {

	public GameObject hex;
	private Vector3 dis;


	// Use this for initialization
	void Start () {
		dis = gameObject.transform.position - hex.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)==true){
			SceneManager.LoadScene (0);
		}

		if(hex != null)
		gameObject.transform.position = dis + hex.transform.position;
	}
		
}

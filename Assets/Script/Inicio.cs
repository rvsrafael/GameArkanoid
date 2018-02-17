using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Return) || Input.touchCount == 2) {
			SceneManager.LoadScene ("game");
		}	
	}
}

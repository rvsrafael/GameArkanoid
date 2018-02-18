using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D c){
		print("passou");

		if(c.gameObject.tag == "gameOver") {
			SceneManager.LoadScene ("Inicio");
		}

	}
	
	void Update () {


	}
}

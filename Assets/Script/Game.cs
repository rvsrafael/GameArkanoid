using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	public GameObject gameObjectFim;
	public GameObject gameObjectGameOver;
	
	void Update () {

		gameObjectFim      = GameObject.FindGameObjectWithTag ("bloco");
		gameObjectGameOver = GameObject.FindGameObjectWithTag ("gameOver");

		if (gameObjectFim == null) {
			SceneManager.LoadScene ("Inicio");
		} 

		if( gameObjectGameOver == null ) {
			SceneManager.LoadScene ("Inicio");
		} 

	}
}

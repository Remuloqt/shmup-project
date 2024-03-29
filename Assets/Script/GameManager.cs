﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections; 

public class GameManager : MonoBehaviour {

	private int score = 0;
	private int health = 5;

	public Text scoreValueObject;
	public Text HealthValueObject;

	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		//updatePlayerLifeUi ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int scoreInrease)
	{
		score += scoreInrease;
		scoreValueObject.text = score.ToString ();
	}

	public void takeHealth(int Healthdecrease)
	{
		if (health == 0) {
			//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			StartCoroutine (levelChange());
		} 
		else {
			health -= Healthdecrease;
			HealthValueObject.text = health.ToString ();
			Debug.Log("Respawn Player");
			GameObject.Instantiate(playerPrefab, Camera.main.transform);

		}
	}


	IEnumerator levelChange()
	{
		PlayerPrefs.SetInt ("score", score);
		yield return SceneManager.LoadSceneAsync("Game over");
	}
		
}

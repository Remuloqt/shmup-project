﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreUpdate : MonoBehaviour {

	private int finalScore = 0;
	public Text finalScoreValueObject;

	// Use this for initialization
	void Start () {
		finalScore = PlayerPrefs.GetInt ("score");
		finalScoreValueObject.text = finalScore.ToString();
	}

}

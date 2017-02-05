using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver: MonoBehaviour {

	public void NewStart()
	{
		Debug.Log("New Game");

		StartCoroutine (levelChange());
	}

	IEnumerator levelChange()
	{
		PlayerPrefs.SetInt ("score", 0);
		yield return SceneManager.LoadSceneAsync("unity");
	}

}


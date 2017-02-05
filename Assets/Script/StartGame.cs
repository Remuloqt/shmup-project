using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void MenuStart()
	{
		Debug.Log("Start game");

		StartCoroutine (levelChange());
	}

	IEnumerator levelChange()
	{
		PlayerPrefs.SetInt ("score", 0);
		yield return SceneManager.LoadSceneAsync("unity");
	}

}

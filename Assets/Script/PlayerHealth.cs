using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public GameObject explosionPrefab;

	public int healthValue = 1;
	public float timer = 2f;

	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.tag == "Enemy") 
		{
			Debug.Log ("osui");
			// Add weapon
			//c.gameObject.enabled = false;
			//yield return new WaitForSeconds (2);
			//c.gameObject.enabled = true;
			Kill ();

		}

	}
		

	public void Kill()
	{
		GameObject.Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy(gameObject);

		GameObject.Find ("GameManager").GetComponent<GameManager> ().takeHealth (healthValue);
	}

	void Start(){
		gameObject.layer = 8;

	}
	void Update(){
		timer -= Time.deltaTime;
		if (timer <= 0) {
			gameObject.layer = 0;
		}
	}


}

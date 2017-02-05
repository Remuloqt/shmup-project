using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWeapon : MonoBehaviour {

	public GameObject projectilePrefab;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject.Instantiate (projectilePrefab, transform.position, Quaternion.identity);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPowerup : MonoBehaviour {

	public PlayerWeaponEnum weaponType;

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") 
		{
			Debug.Log ("Power up");
			// Add weapon

			c.gameObject.GetComponent<PlayerWeaponManager> ().AddWeapon (weaponType);
			Destroy (gameObject);
		}
	}
}

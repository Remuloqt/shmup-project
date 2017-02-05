using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour {

	private List<IWeapon> activeWeapons = new List<IWeapon>();



	public GameObject simpleWeaponProjectile;
	public GameObject powerfulWeaponProjectile;
	public AudioSource laserSound;

	// Use this for initialization
	void Start () {
		activeWeapons.Add (new SimpleWeapon1 (simpleWeaponProjectile));
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")){
			foreach(IWeapon w in activeWeapons){
				w.Fire(transform.position);
				laserSound.Play ();

			}
		}

	}

	public void AddWeapon(PlayerWeaponEnum weaponType)
	{
		Debug.Log ("Add new weapon");
		switch (weaponType) {
		case PlayerWeaponEnum.BasicBlaster:
			break;
		case PlayerWeaponEnum.TwinBlaster:
			
			break;
		case PlayerWeaponEnum.PowerfulWeapon:
			activeWeapons.Add (new PowerfulWeapon (powerfulWeaponProjectile));
			break;

		default:
			Debug.Log ("WeaponType:" + weaponType + " not implemented yet");
			return;
		}
	}
}

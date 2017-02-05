using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWeapon1 : IWeapon {

	private GameObject projectilePrefab;

	public SimpleWeapon1(GameObject projectile)
	{
		projectilePrefab = projectile;
	}

	public void Fire(Vector2 position)
	{
		GameObject.Instantiate (projectilePrefab, position, Quaternion.identity);
	}
}

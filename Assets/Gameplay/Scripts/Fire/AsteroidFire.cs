﻿using UnityEngine;
using System.Collections;

public class AsteroidFire : FireComponent {

	public GameObject missile;
	private bool fire_enabled = true;

    public override void Fire(InputParams _input) {
		if (fire_enabled) {
			Instantiate (missile, transform.position + transform.up * 1.3f, transform.rotation);
			fire_enabled = false;
			StartCoroutine(CannotFire());
		}


	}

	IEnumerator CannotFire() {
		yield return new WaitForSeconds(1f);
		fire_enabled = true;
	}


}

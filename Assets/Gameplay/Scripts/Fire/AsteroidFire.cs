using UnityEngine;
using System.Collections;

public class AsteroidFire : FireComponent {

	public GameObject missile;

    public override void Fire(InputParams _input) {
		Debug.LogError ("FIRE!");

		Instantiate (missile, transform.position + transform.up * 1.3f, transform.rotation);

	}



}

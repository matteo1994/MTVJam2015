using UnityEngine;
using System.Collections;

public class SHMUPFire : FireComponent {

	public GameObject missile;
	private bool fire_enabled = true;

    public override void Fire(InputParams _input) {
		if (fire_enabled) {
			Instantiate (missile, transform.position + transform.up * .7f, transform.rotation);
			fire_enabled = false;
			SoundManager.instance.PlayFire();
			StartCoroutine(CannotFire());
		}


	}

	IEnumerator CannotFire() {
		yield return new WaitForSeconds(.1f);
		fire_enabled = true;
	}


}

using UnityEngine;
using System.Collections;

public class AsteroidChar : AbstractCharacter {

	void Start() {
		SoundManager.instance.PlayAsteroids ();
	}

}

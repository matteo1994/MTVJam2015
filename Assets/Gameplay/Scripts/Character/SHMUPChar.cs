using UnityEngine;
using System.Collections;

public class SHMUPChar : AbstractCharacter {
	void Start() {
		SoundManager.instance.PlaySHMUP ();
	}

}

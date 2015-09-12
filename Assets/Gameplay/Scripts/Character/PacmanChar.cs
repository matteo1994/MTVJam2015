using UnityEngine;
using System.Collections;

public class PacmanChar : AbstractCharacter {
	void Start() {
		SoundManager.instance.PlayPacman ();
	}

}

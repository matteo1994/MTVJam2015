using UnityEngine;
using System.Collections;

public class PongCharacter : AbstractCharacter
{
	void Start() {
		SoundManager.instance.PlayPong ();
	}

}

using UnityEngine;
using System.Collections;

public class PlatformerChar : AbstractCharacter {
   void Start() {
		SoundManager.instance.PlayMario ();
	}
}

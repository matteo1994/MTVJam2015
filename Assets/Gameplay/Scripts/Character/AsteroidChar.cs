using UnityEngine;
using System.Collections;

public class AsteroidChar : AbstractCharacter {

    public override void Start()
    {
        base.Start();
        SoundManager.instance.PlayAsteroids ();
	}

}

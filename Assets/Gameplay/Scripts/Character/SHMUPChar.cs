using UnityEngine;
using System.Collections;

public class SHMUPChar : AbstractCharacter {

    public override void Start()
    {
        base.Start();
        SoundManager.instance.PlaySHMUP ();
	}

}

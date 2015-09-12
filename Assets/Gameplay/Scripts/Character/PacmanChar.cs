using UnityEngine;
using System.Collections;

public class PacmanChar : AbstractCharacter
{
    public override void Start()
    {
        base.Start();
        SoundManager.instance.PlayPacman ();
	}

}

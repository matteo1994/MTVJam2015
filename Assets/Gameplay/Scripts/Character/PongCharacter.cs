using UnityEngine;
using System.Collections;

public class PongCharacter : AbstractCharacter
{
	public override void Start()
    {
        base.Start();
    SoundManager.instance.PlayPong ();
    }

}

using UnityEngine;
using System.Collections;

public class GhostChar : AbstractCharacter {

    public override void Start()
    {
        base.Start();
        SoundManager.instance.PlayPacman();
    }

}

using UnityEngine;
using System.Collections;

public class PlatformerChar : AbstractCharacter {

    public GameObject levelGo;

    public override void Start()
    {
        base.Start();
        SoundManager.instance.PlayMario ();

        levelGo.transform.parent = null;

        this.transform.position += Vector3.down * 4;
    }

    void OnDestroy()
    {
        Destroy(levelGo);
    }

}

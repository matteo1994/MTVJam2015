using UnityEngine;
using System.Collections;

public class PongCharacter : AbstractCharacter
{
    public GameObject ballGo;

    private BoxCollider coll;

	public override void Start()
    {
        base.Start();
        SoundManager.instance.PlayPong ();

        ballGo.transform.parent = null;

        coll = GetComponentInChildren<BoxCollider>();
    }


    public override void Update()
    {
        base.Update();
        if (coll.bounds.Contains(ballGo.transform.position))
            ballGo.GetComponent<MoveBall>().direction.y *= -1;
    }


    void OnDestroy()
    {
        Destroy(ballGo);
    }

}

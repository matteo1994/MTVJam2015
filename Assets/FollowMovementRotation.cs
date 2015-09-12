using UnityEngine;
using System.Collections;

public class FollowMovementRotation : MonoBehaviour {

    MovePacman mover;

    public void Awake()
    {
        mover = GetComponent<MovePacman>();
    }

    void Update()
    {
       // this.transform.forward = mover.direction;
    }
}

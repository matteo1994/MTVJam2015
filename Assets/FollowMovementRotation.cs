using UnityEngine;
using System.Collections;

public class FollowMovementRotation : MonoBehaviour {

    MovePacman mover;

    public void Awake()
    {
        mover = transform.parent.GetComponent<MovePacman>();
    }

    void Update()
    {
        if (mover.direction == Vector3.left || mover.direction == Vector3.right)
            transform.forward = mover.direction;
        else
        {
            transform.forward = mover.direction;
            transform.Rotate(0, 0, 90);
        }

        //transform.forward = mover.direction;
        //this.transform.LookAt(mover.direction, Vector3.back);
        }
}

using UnityEngine;
using System.Collections;

public abstract class MoveComponent : MonoBehaviour {

    public abstract void Move(InputParams _input);

    public virtual void Bounce()
    {
        // NOTHING
    }

}

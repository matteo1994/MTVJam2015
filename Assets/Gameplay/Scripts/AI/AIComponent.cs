using UnityEngine;
using System.Collections;

public abstract class AIComponent : MonoBehaviour {

    public abstract void GetInput(InputParams _input);

}

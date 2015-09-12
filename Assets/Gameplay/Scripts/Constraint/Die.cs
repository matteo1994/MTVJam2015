using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
    public bool isDown = false;
    public bool isUp = false;

    void Update () {
        if (isUp)
            if (transform.position.y > ConstVar.Y_LIMIT)
                Destroy(this.gameObject);
        if (isDown)
            if (transform.position.y < -ConstVar.Y_LIMIT)
                Destroy(this.gameObject);
    } 
}

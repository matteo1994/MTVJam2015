using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public bool isX = false;
    public  bool isY = false;

	void Update () {
        if (isX)
        {
            if (transform.position.x > ConstVar.X_LIMIT)
                GetComponent<MoveBall>().direction.x *= -1;
            if (transform.position.x < -ConstVar.X_LIMIT)
                GetComponent<MoveBall>().direction.x *= -1;
        }

        if (isY)
        {
            if (transform.position.y > ConstVar.Y_LIMIT)
                GetComponent<MoveBall>().direction.y *= -1;
            if (transform.position.y < -ConstVar.Y_LIMIT)
                GetComponent<MoveBall>().direction.y *= -1;
        }
	}
}

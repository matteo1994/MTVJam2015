using UnityEngine;
using System.Collections;

public class Toroid : MonoBehaviour {

    public bool isX = false;
    public bool isY = false;

    private bool firstEntrance = true;

    public float offsetX = 0;

	// Update is called once per frame
	void Update () {
        if (firstEntrance)
        {
            if ((transform.position.x < ConstVar.X_LIMIT && transform.position.x > -ConstVar.X_LIMIT)
                && (transform.position.y < ConstVar.Y_LIMIT && transform.position.y > -ConstVar.Y_LIMIT))
                firstEntrance = false;
            return;
        }

        if (isX)
        {
            if (transform.position.x > ConstVar.X_LIMIT + offsetX)
                transform.position += Vector3.left * 2f * ( ConstVar.X_LIMIT + offsetX);
            if (transform.position.x < -ConstVar.X_LIMIT - offsetX)
                transform.position += Vector3.right * 2f * (ConstVar.X_LIMIT + offsetX);
        }

        if (isY)
        {
            if (transform.position.y > ConstVar.Y_LIMIT)
                transform.position += Vector3.down * 2f * ConstVar.Y_LIMIT;
            if (transform.position.y < -ConstVar.Y_LIMIT)
                transform.position += Vector3.up * 2f * ConstVar.Y_LIMIT;
        } 
	}
}

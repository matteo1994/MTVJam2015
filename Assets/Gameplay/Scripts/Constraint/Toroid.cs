using UnityEngine;
using System.Collections;

public class Toroid : MonoBehaviour {

    public bool isX = false;
    public bool isY = false;

    float x_limit = 11f;
	float y_limit = 7.5f;

	// Update is called once per frame
	void Update () {
        if (isX)
        {
            if (transform.position.x > x_limit)
                transform.position += Vector3.left * 2f * x_limit;
            if (transform.position.x < -x_limit)
                transform.position += Vector3.right * 2f * x_limit;
        }

        if (isY)
        {
            if (transform.position.y > y_limit)
                transform.position += Vector3.down * 2f * y_limit;
            if (transform.position.y < -y_limit)
                transform.position += Vector3.up * 2f * y_limit;
        }
	}
}

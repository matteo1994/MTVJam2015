using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public bool isX = false;
    public  bool isY = false;

    float x_limit = 11f;
	float y_limit = 7.5f;

	void Update () {
        if (isX)
        {
            if (transform.position.x > x_limit)
                GetComponent<MoveComponent>().Bounce();//.direction.x *= -1;
            if (transform.position.x < -x_limit)
                GetComponent<MoveComponent>().Bounce(); //direction.x *= -1;
        }

        if (isY)
        {
            if (transform.position.y > y_limit)
                GetComponent<MoveComponent>().Bounce(); //.direction.y *= -1;
            if (transform.position.y < -y_limit)
                GetComponent<MoveComponent>().Bounce(); //.direction.y *= -1;
        }
	}
}

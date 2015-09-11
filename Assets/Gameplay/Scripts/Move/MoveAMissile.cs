using UnityEngine;
using System.Collections;

public class MoveAMissile : MoveComponent {

    public float speed = 30f;
    public  Vector3 direction = Vector3.up;

    void Awake()
    {
        direction = Vector3.up;
    }

    public override void Move (InputParams _input) {
		transform.position = transform.position + transform.up * speed * Time.deltaTime;
    }

}

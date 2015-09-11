using UnityEngine;
using System.Collections;

public class MoveLinear : MoveComponent {
    public float speed = 10;
    public Vector3 direction = Vector3.down;

    public override void Move(InputParams _input)
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

}

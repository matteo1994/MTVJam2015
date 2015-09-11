using UnityEngine;
using System.Collections;

public class MoveAMissile : MoveComponent {

    public float speed = 3f;
    public  Vector3 direction = Vector3.up;

    void Awake()
    {
        direction = Vector3.up;
        direction = Quaternion.AngleAxis(Random.Range(-45f,45f), Vector3.forward) * direction;
    }

    public override void Move (InputParams _input) {
        var tmpPos = this.transform.position;
        tmpPos += direction * speed * Time.deltaTime;
        this.transform.position = tmpPos;
    }

}

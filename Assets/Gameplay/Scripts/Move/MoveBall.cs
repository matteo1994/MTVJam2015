using UnityEngine;
using System.Collections;

public class MoveBall : MoveComponent {

    public float speed = 3f;
    public  Vector3 direction = Vector3.up;
    public float rangeFromUp = 90f;

    void Awake()
    {
        direction = Vector3.up;
        direction = Quaternion.AngleAxis(Random.Range(-rangeFromUp/2, rangeFromUp / 2), Vector3.forward) * direction;
    }

    public override void Move (InputParams _input) {
        var tmpPos = this.transform.position;
        tmpPos += direction * speed * Time.deltaTime;
        this.transform.position = tmpPos;
    }

}

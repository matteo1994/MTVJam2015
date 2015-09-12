using UnityEngine;
using System.Collections;

public class MoveBall : MoveComponent {

    public float speed = 3f;
    public  Vector3 direction = Vector3.up;
    public float rangeFromUp = 90f;

    public bool goToCenter = false;

    void Awake()
    {
        direction = Vector3.up;
        direction = Quaternion.AngleAxis(Random.Range(-rangeFromUp / 2, rangeFromUp / 2), Vector3.forward) * direction;

        if (goToCenter) {  
            direction = (Camera.main.transform.position - this.transform.position).normalized; direction.z = 0;
        }
    }

    public override void Move (InputParams _input) {
        var tmpPos = this.transform.position;
        tmpPos += direction * speed * Time.deltaTime;
        this.transform.position = tmpPos;
    }

}

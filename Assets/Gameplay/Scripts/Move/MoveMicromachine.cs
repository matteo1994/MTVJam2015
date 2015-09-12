using UnityEngine;
using System.Collections;

public class MoveMicromachine : MoveComponent {
    public float speed = 10;
    public float rotSpeed = 30;

    public int rotDirection = 1;

    //private Vector3 direction = Vector3.up;

    public override void Move(InputParams _input)
    {
        //Debug.Log(direction);
        var tmpPos = this.transform.position;
        //tmpPos.x += _input.x * speed * Time.deltaTime;
        //tmpPos.y += _input.y * speed * Time.deltaTime;

        tmpPos += transform.up * _input.y * speed * Time.deltaTime;

        transform.up = Quaternion.AngleAxis(rotSpeed * Time.deltaTime * _input.x * rotDirection, Vector3.forward) * transform.up;

        //transform.up = direction;

        this.transform.position = tmpPos;

        Debug.DrawLine(this.transform.position, this.transform.position + transform.up * 2);
    }

}

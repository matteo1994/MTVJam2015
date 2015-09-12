using UnityEngine;
using System.Collections;

public class MoveAsteroid : MoveComponent {
    public float rotSpeed = 100f;
	public float current_speed = 0f;
	public float max_speed = 50f;
	public float acceleration = 10f;

     Vector3 direction = Vector3.zero;

    public override void Move(InputParams _input)
    {
		if (_input.y > 0) {
			current_speed = current_speed + acceleration * Time.deltaTime;
			current_speed = Mathf.Min (current_speed, max_speed);
		}

        //transform.Rotate (- _input.x * rotSpeed * Time.deltaTime * Vector3.forward);
        transform.up = Quaternion.AngleAxis(-rotSpeed * Time.deltaTime * _input.x, Vector3.forward) * transform.up;
        //transform.up = direction;

        if (_input.y > 0)
            direction = direction + transform.up * _input.y * Time.deltaTime;

        this.transform.position = this.transform.position + direction * current_speed * Time.deltaTime;

        //Debug.DrawLine(this.transform.position, this.transform.position + transform.up * 2);
    }

}

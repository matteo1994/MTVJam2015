using UnityEngine;
using System.Collections;

public class MoveAsteroid : MoveComponent {
    public float speed = 10f;
    public float rotSpeed = 30f;

	public float current_speed = 0f;
	public float max_speed = 100f;
	public float acceleration = 10f;

    public override void Move(InputParams _input)
    {
        var tmpPos = this.transform.position;

		Debug.Log ("X = " + _input.x+ " Y = " + _input.y);

		if (_input.y > 0) {
			current_speed = current_speed + acceleration * Time.deltaTime;
			current_speed = Mathf.Min (current_speed, max_speed);
		}

		transform.Rotate (- _input.x * rotSpeed * Time.deltaTime * Vector3.forward);

		this.transform.position = this.transform.position + transform.up*current_speed*Time.deltaTime;

        Debug.DrawLine(this.transform.position, this.transform.position + transform.up * 2);
    }

}

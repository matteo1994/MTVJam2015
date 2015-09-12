using UnityEngine;
using System.Collections;

public class MovePlatformer : MoveComponent {

	class Cinematic {
		public float x;
		public float y;

		public Cinematic(float _x, float _y) {
			x = _x;
			y = _y;
		}
	}

	public bool onPlatform = true;
	public bool isJumping = false;

	public float gravity = 9.8f*2.5f;

	Cinematic current_speed = new Cinematic(0f,0f);
	Cinematic acceleration = new Cinematic(10f,0f);

	public float max_speed = 20f;

    public override void Move(InputParams _input)
    {
		if (!onPlatform) {

		}

		if (_input.fire) {
			Debug.LogError("JUMP");
			//current_speed = current_speed + acceleration * Time.deltaTime;
			//current_speed = Mathf.Min (current_speed, max_speed);
		}

		if (onPlatform) {
			if (_input.x != 0) {
				current_speed.x = current_speed.x + Mathf.Sign(_input.x) * acceleration.x * Time.deltaTime;
				//current_speed.x = Mathf.Min (current_speed, max_speed);
			}
		}
    }

}

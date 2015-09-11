using UnityEngine;
using System.Collections;

public class MoveSHMUP : MoveComponent {

	public float speed = 10f;

	public void Awake()
	{
		transform.position = new Vector3 (0, -3.55f, 0);
	}

	public override void Move (InputParams _input) {

		if (_input.y != 0) {
			if (_input.y < 0)
				transform.position += Vector3.down * Time.deltaTime * speed; 
			if (_input.y > 0)
				transform.position += Vector3.up * Time.deltaTime * speed; 
		} else {

			if (_input.x != 0) {
				if (_input.x < 0)
					transform.position += Vector3.left * Time.deltaTime * speed; 
				if (_input.x > 0)
					transform.position += Vector3.right * Time.deltaTime * speed; 
			}
		}
	}

}

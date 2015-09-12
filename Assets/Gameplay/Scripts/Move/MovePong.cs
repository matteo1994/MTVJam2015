using UnityEngine;
using System.Collections;

public class MovePong : MoveComponent {

	private float speed = 10f;
    public bool is_vertical = false;

	public void Awake()
	{
		SoundManager.instance.PlayPong ();

		if (is_vertical)
			transform.position = new Vector3 (8.5f, 0, 0);
		else 
			transform.position = new Vector3 (0, -3.55f, 0);
	}

	public override void Move (InputParams _input) {
		if (is_vertical) {
			Debug.LogError("VERTICALE");
			if (_input.y < 0)
				transform.position += Vector3.down * Time.deltaTime * speed; 
			if (_input.y > 0)
				transform.position += Vector3.up * Time.deltaTime * speed; 
		} else {
			if (_input.x < 0)
				transform.position += Vector3.left * Time.deltaTime * speed; 
			if (_input.x > 0)
				transform.position += Vector3.right * Time.deltaTime * speed; 
		}
	}

	public void OnDestroy() {
		SoundManager.instance.StopPong ();
	}

    //public override void Action (ActionParams _action) {}
    //public override void Do () {}

}

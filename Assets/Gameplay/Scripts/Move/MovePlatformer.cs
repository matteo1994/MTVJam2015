using UnityEngine;
using System.Collections;

public class MovePlatformer : MoveComponent {


	PlatformerChar platformerChar;

	float y0 = 0f;
	float height = 1.2f; 
	float offset = .1f;

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
	private float speed = 5f;

	private float gravity = 50f;


	Cinematic current_speed = new Cinematic(0f,0f);
	Cinematic acceleration = new Cinematic(10f,20f);

	void Awake() {
		y0 = transform.position.y;
		Debug.LogError ("Y0=" + y0);

		platformerChar = GetComponent<PlatformerChar> ();

	}

    public override void Move(InputParams _input)
    {
		float dx = 0;

		if (!onPlatform) {
			current_speed.y = current_speed.y + acceleration.y * Time.deltaTime - gravity*Time.deltaTime;
			transform.position = transform.position + Time.deltaTime*(transform.up*current_speed.y+transform.right*current_speed.x);
		}

		if (onPlatform) {
			if (!isJumping && _input.fire) {

				isJumping = true;
				onPlatform = false;

				current_speed.y = 15f + current_speed.y + acceleration.y * Time.deltaTime - gravity*Time.deltaTime;

			} 

			if (_input.x!=0)
				current_speed.x = Mathf.Sign (_input.x)*speed;
			else current_speed.x = 0;

			transform.position = transform.position + Time.deltaTime*(transform.up*current_speed.y+transform.right*current_speed.x);


		}
    }

	void Update() {
		if (transform.position.y < -5.5f) {
			Debug.LogError("I AM DYING!");
			platformerChar.Kill();
		}
	}

	void OnTriggerEnter(Collider other) {
		Debug.LogError ("COLLISION!");
		if (other.gameObject.tag == "Platform") {
			Vector3 d = transform.position - other.gameObject.transform.position;

			Debug.LogError("D = "+d);
			if (d.y<offset) return; 

			current_speed.y = 0f;
			transform.position = new Vector3(transform.position.x,other.gameObject.transform.position.y+height, transform.position.z);
			onPlatform = true;
			isJumping = false;
			Debug.LogError("LANDED! YO!");
		}
	}
	
	void OnTriggerExit(Collider other) {
		Vector3 d = transform.position - other.gameObject.transform.position;
		
//		Debug.LogError("D = "+d);
//		if (d.y < .1)
//			onPlatform = true;
//		else
			onPlatform = false;
	}
}

using UnityEngine;
using System.Collections;

public class MovePacman : MoveComponent {
    public float speed = 10;

	public void Start() {
		SoundManager.instance.PlayPacman ();
	}

    [HideInInspector]
    public Vector3 direction;

    public override void Move(InputParams _input)
    {
        var tmpPos = this.transform.position;

        if (_input.x > 0)
            direction = Vector3.right;
        if (_input.x < 0)
            direction = Vector3.left;
        if (_input.y > 0)
            direction = Vector3.up;
        if (_input.y < 0)
            direction = Vector3.down;

        tmpPos += direction * speed * Time.deltaTime;
        //tmpPos.x += _input.x * speed * Time.deltaTime;
        //tmpPos.y += _input.y * speed * Time.deltaTime;
        this.transform.position = tmpPos;
    }

	public void OnDestroy() {
		SoundManager.instance.StopPong ();
	}

}

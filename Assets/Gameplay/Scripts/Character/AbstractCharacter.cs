using UnityEngine;
using System.Collections;

public class AbstractCharacter : MonoBehaviour {

	InputParams input = new InputParams ();
    //ActionParams action = new ActionParams();

    public bool canDie = false;
    public bool canKill = false;

    public int playerId = 0;

    public static AbstractCharacter mainCharacter;

    MoveComponent moveComponent;
	FireComponent fireComponent;

    AIComponent aiComponent;

    public bool isPlayer = false;
    void Start()
    {
        if (isPlayer) mainCharacter = this;
        moveComponent = GetComponent<MoveComponent>();
		fireComponent = GetComponent<FireComponent>();
        aiComponent = GetComponent<AIComponent>();
    }

    void Update () {
        if (aiComponent != null)
            aiComponent.GetInput(input);
        else
		    GetPlayerInput (input, playerId);

        if (moveComponent != null)
            moveComponent.Move(input);

		if (fireComponent != null && input.fire)
			fireComponent.Fire (input);
    }

    void GetPlayerInput(InputParams _input, int playerId)
	{
		_input.x = Input.GetAxis ("Horizontal_" + playerId); 
		_input.y = Input.GetAxis ("Vertical_" + playerId); 
		_input.fire = Input.GetButtonDown ("Fire1_"+playerId);
        Debug.Log(_input.x + " " + playerId);
		//_input.jump = Input.GetButtonDown ("Fire2_" + playerId);
		//Debug.LogError (">> X=" + _input.x + " Y=" + _input.y);
	}

    #region Collisions
    void OnCollisionEnter(Collision other)
    {
        if (canDie)
        {
            Debug.Log(this.name + " DIES");
            Destroy(this.gameObject);

            ScoreGUI.scoreGUI.score += 200;
        } 

        if (canKill)
        {
            Debug.Log(this.name + " KILLS");
            Destroy(other.gameObject);

            ScoreGUI.scoreGUI.score += 50;
        }
    }
    #endregion
}

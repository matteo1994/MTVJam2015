﻿using UnityEngine;
using System.Collections;

public class AbstractCharacter : MonoBehaviour {

	InputParams input = new InputParams ();
    //ActionParams action = new ActionParams();

    public bool canDie = false;
    public bool canKill = false;

    public int playerId = -5;

    public static AbstractCharacter mainCharacter;

    public GameObject explosionPrefabGo;

    MoveComponent moveComponent;
	FireComponent fireComponent;
    AIComponent aiComponent;

    bool invicible = false;
    float invincibleTime = 1f;

    public bool isPlayer = false;
    public virtual void Start()
    {
        invicible = true;

        explosionPrefabGo = Resources.Load("Explosion") as GameObject;
        if (isPlayer) mainCharacter = this;
        moveComponent = GetComponent<MoveComponent>();
		fireComponent = GetComponent<FireComponent>();
        aiComponent = GetComponent<AIComponent>();
    }

    virtual public void Update () {
        if (aiComponent != null)
            aiComponent.GetInput(input);
        else
		    GetPlayerInput (input, playerId);

        if (moveComponent != null)
            moveComponent.Move(input);

		if (fireComponent != null && input.fire)
			fireComponent.Fire (input);


        invincibleTime -= Time.deltaTime;
        if (invincibleTime < 0)
            invicible = false;
    }

    void GetPlayerInput(InputParams _input, int playerId)
	{
		_input.x = Input.GetAxis ("Horizontal_" + playerId); 
		_input.y = Input.GetAxis ("Vertical_" + playerId); 
		_input.fire = Input.GetButtonDown ("Fire1_"+playerId);
        //Debug.Log(_input.x + " " + playerId);
		//_input.jump = Input.GetButtonDown ("Fire2_" + playerId);
		//Debug.LogError (">> X=" + _input.x + " Y=" + _input.y);
	}

    public void SetPlayer(int playerId)
    {
        this.playerId = playerId;
        isPlayer = true;
    }

    #region Collisions
    void OnCollisionEnter(Collision other)
    {
        if (canDie && !invicible)
        {
            //Debug.Log(this.name + " HIT " + other.name);
            //Debug.Log(this.name + " DIES " + playerId);
            Kill();

        } 

        if (canKill)
        {
            //Debug.Log(this.name + " KILLS");
            other.gameObject.GetComponent<AbstractCharacter>().Kill();
        }
    }

    bool dead = false;
    public void Kill()
    {
        if (dead) return;
        dead = true;
        Debug.Log("I AM BEING KILLED " + playerId + " " + this.name);

        if (explosionPrefabGo != null)
            Instantiate(explosionPrefabGo, this.transform.position, Quaternion.identity);
        //SoundManager.instance.PlayExplosion();

        Destroy(this.gameObject);

        if (isPlayer)
            ScoreGUI.scoreGUI.score -= 300;

        if (!isPlayer)
            ScoreGUI.scoreGUI.score += 100;

        if (this.isPlayer)
            GameController.Instance.KillPlayer(playerId);

    }

    #endregion
}

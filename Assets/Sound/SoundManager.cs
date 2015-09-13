using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	static public SoundManager instance { get { return _instance; } }

	public AudioSource[] audio_background = new AudioSource[3];

	public AudioSource pacman;

	public AudioSource asteroids;

	public AudioSource frogger;

	public AudioSource[] mario = new AudioSource[3];

	public AudioSource shmup;

	public AudioSource pong;

	public AudioSource[] fire = new AudioSource[5];

	public AudioSource[] explosion = new AudioSource[3];

	static private SoundManager _instance = null;
	int current_background = 0;


	void Awake () {
		///
		/// singleton pattern
		/// 
		if (_instance == null) {
			_instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}


	}

	void Start() {
		PlayBackground ();
		//PlayPacman ();
		//PlayFrogger ();
		//PlayAsteroids ();
		//PlayFrogger ();
		//PlaySHMUP ();
		//PlayPong ();
		//PlayMario();

	}

	public void PlayBackground() {
		current_background = Random.Range (0, 3);
		audio_background [current_background].Play ();
	}

	public void StopBackground() {
		audio_background [current_background].Stop ();
	}

	#region Pacman
	public void PlayPacman() {
		audio_background [current_background].volume = .8f;
		pacman.Play ();
	}
	
	public void StopPacman() {
		pacman.Stop ();
		audio_background [current_background].volume = 1f;
	}
	#endregion

	#region Asteroids
	public void PlayAsteroids() {
		asteroids.Play ();
	}
	
	public void StopAsteroids() {
		asteroids.Stop ();
	}
	#endregion

	#region Frogger
	public void PlayFrogger() {
		frogger.Play ();
	}
	
	public void StopFrogger() {
		frogger.Stop ();
	}
	#endregion

	#region Shmup
	public void PlaySHMUP() {
		shmup.Play ();
	}
	
	public void StopSHMUP() {
		shmup.Stop ();
	}
	#endregion

	#region Pong
	public void PlayPong() {
		pong.Play ();
	}
	
	public void StopPong() {
		pong.Stop ();
	}
	#endregion

	#region Mario
	public void PlayMario() {
		mario [Random.Range (0, 3)].Play ();
	}
	
	public void StopMario() {
		mario [0].Stop ();
		mario [1].Stop ();
		mario [2].Stop ();
	}

	#endregion

	#region Fire
	public void PlayFire() {
		fire [Random.Range (0, 5)].Play ();
	}	
	#endregion

	#region Explosion
	public void PlayExplosion() {
		explosion [Random.Range (0, 5)].Play ();
	}	
	#endregion

}

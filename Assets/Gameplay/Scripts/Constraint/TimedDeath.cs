using UnityEngine;
using System.Collections;

public class TimedDeath : MonoBehaviour {

	public float die_after = 5f;
	private float end_time = 0f;

	// Use this for initialization
	void Start () {
		end_time = Time.time + die_after;

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > end_time)
			Destroy (gameObject);
	}
}

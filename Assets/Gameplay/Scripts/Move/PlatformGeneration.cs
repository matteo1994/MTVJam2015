using UnityEngine;
using System.Collections;

public class PlatformGeneration : MonoBehaviour {

	float creation_after = 4f;
	float destruction_after = 3f; 
	float upper_limit = 15f;
	float lower_limit = -15f;


	public GameObject platform;

	// Use this for initialization
	void Start () {
		StartCoroutine (GeneratePlatforms ());
	}

	IEnumerator GeneratePlatforms() {
		yield return new WaitForSeconds (creation_after);

//		float dx = Random.Range ();
//		Vector3 pp1 = new Vector3
//		Instantiate

		yield return null;
	}
}

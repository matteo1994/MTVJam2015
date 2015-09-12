using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public Vector3 rotDir;
    public float speed;
        
	void Update () {
        transform.Rotate(rotDir * speed * Time.deltaTime);
	}
}

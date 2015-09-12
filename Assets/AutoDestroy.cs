using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {
    public float delay;
	void Start () {
        Invoke("Kill", delay);
	}
	
	void Kill () {
        Destroy(this.gameObject);
	}
}

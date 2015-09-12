using UnityEngine;
using System.Collections;

public class GoToScene : MonoBehaviour {
    public string sceneName;

    public float delay = 0;

	void Start () {
        if (delay == 0)
            Application.LoadLevel(sceneName);
        else
            Invoke("Go", delay);
	}

    float t = 0;
    void Update()
    {
        t += Time.deltaTime;
       // Debug.Log(t);
    }

    void Go()
    {
        Application.LoadLevel(sceneName);
    }
}

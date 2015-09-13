using UnityEngine;
using System.Collections;

public class GoToGame : MonoBehaviour {
	
    void Awake()
    {
        Time.timeScale = 1;
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Gameplay Michele");
        }
	}
}

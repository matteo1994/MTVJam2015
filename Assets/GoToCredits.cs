using UnityEngine;
using System.Collections;

public class GoToCredits : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("credits");
        }
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PL1GUI : MonoBehaviour {

    public Text textUi;

	void Update () {
        textUi.text = "P1: " + GameController.Instance.pl1Life;
    }

}

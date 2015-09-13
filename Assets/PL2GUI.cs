using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PL2GUI : MonoBehaviour {

    public Text textUi;

	void Update () {
        textUi.text = "P2: " + GameController.Instance.pl2Life;
    }

}

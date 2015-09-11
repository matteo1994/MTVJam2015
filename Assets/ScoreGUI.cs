using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreGUI : MonoBehaviour {

    public static ScoreGUI scoreGUI;

    public float score;
    Text textUi;

    void Awake()
    {
        scoreGUI = this;
        textUi = GetComponent<Text>();
    }

	void Update () {
        score += 10 * Time.deltaTime;
        textUi.text =  score.ToString("0000000");
    }

}

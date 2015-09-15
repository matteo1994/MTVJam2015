using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PLCursor : MonoBehaviour {

    public Text textUi;
    public int playerId;

    public RectTransform rectTr;
    public Transform targetTr;

	void Update () {
        if (targetTr == null)
        {
            rectTr.anchoredPosition = Vector3.right * 1000;
            return;
        }

        rectTr.anchoredPosition = Camera.main.WorldToScreenPoint(targetTr.position)
            + new Vector3(-Screen.width / 2, -Screen.height / 2)
            + Vector3.up*50;

        textUi.text = "PL" + playerId.ToString();
    }

}

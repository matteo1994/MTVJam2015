using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Flash : MonoBehaviour {

	public void DoFlash () {
        this.GetComponent<Image>().color = Color.white;
        Invoke("Reset", 0.1f);
	}

    void Reset()
    {
        this.GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }
}

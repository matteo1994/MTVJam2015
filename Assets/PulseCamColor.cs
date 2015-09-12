using UnityEngine;
using System.Collections;

public class PulseCamColor : MonoBehaviour {
    float t = 0.0f;

    public Color color;

    public float frequency = 5.0f;
	void Update ()
    {
        t += Time.deltaTime;
        Camera.main.backgroundColor = Color.Lerp(Color.black, color, 0.5f+Mathf.Sin(t * frequency));

	}

}

using UnityEngine;
using System.Collections;

public class PulseLightColor : MonoBehaviour {
    float t = 0.0f;

    public Color color;

    public Light light;

    public float frequency = 5.0f;
	void Update ()
    {
        t += Time.deltaTime;
        light.color = Color.Lerp(Color.black, color, Mathf.PerlinNoise(t * frequency, 0));
       
    }

}

using UnityEngine;

public class AnimateTextures : MonoBehaviour {
	
	public float FramesPerSecond;
	public Texture[] artex;
	int frame = 0;
	private float SecondsPerFrame;
	float timer = 0.0f;
	
	void Start() { SecondsPerFrame = 1.0f / FramesPerSecond; }
	
	void Update () {
		
		if (timer >= SecondsPerFrame) {
			int iT = Mathf.FloorToInt(timer / SecondsPerFrame);
			timer -= SecondsPerFrame * iT; 
			frame = (frame + iT) % artex.Length;
			GetComponent<Renderer>().material.mainTexture = artex[frame];
		}
		timer += Time.deltaTime;
	}
}
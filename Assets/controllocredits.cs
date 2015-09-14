using UnityEngine;
using System.Collections;

public class controllocredits : MonoBehaviour {
	public GameObject gameover_text;
	public GameObject titlecredits;
	public GameObject pg1;
	public GameObject pg2;
	public GameObject pg3;
	public GameObject pg4;
	public GameObject pg5;
	public GameObject pg6;
	public GameObject pg7;
	public GameObject pg8;

	private float readstep=0f;
	private float delay=1f;
	private float timerint=0f;

	void Start () {
		readstep = timerint + delay;
	}
	


	void Update () {
		if (timerint > readstep)
		{
			readstep = timerint + delay;
			
			StartCoroutine(readmore());
		}
		timerint+= Time.deltaTime;
		Debug.Log ("time "+timerint);
	}
	public IEnumerator readmore()
	{
		yield return new WaitForSeconds(1);
		Debug.Log ("steptext "+readstep);
		//gameover - fadeout
		if (readstep > 6) {
			gameover_text.SetActive(false);

		}
		
		if (readstep > 9) {
			pg1.SetActive(false);
			
		}
		
		if (readstep > 12) {
			pg2.SetActive(false);
			
		}
		if (readstep > 15) {
			pg3.SetActive(false);
			
		}
		if (readstep > 18) {
			pg4.SetActive(false);
			
		}
		if (readstep > 21) {
			pg5.SetActive(false);
			
		}
		if (readstep > 24) {
			pg6.SetActive(false);
			titlecredits.SetActive(false);
		}
		if (readstep > 33) {
			pg7.SetActive(false);

		}
		if (readstep > 50) {
			//pg8.SetActive(false);
			Application.LoadLevel("Gameplay Michele");
		}
	
	}
	
}

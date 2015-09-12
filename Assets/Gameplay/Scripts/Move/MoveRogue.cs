using UnityEngine;
using System.Collections;

public class MoveRogue : MoveComponent
{// parametri da settera in base alle dimensioni dell'oggetto 
    public float speed = 0.5f;
    public float y_dir = 0.1f;
    public float x_dir = 0.2f;
    public float timeToWait = 0.4f;

    public void Awake()
    {
        //SoundManager.instance.PlayPong();
        transform.position = new Vector3(0, -3.55f, 0);
    }

    [HideInInspector]
    public Vector3 direction;
    private bool flag = true;

    public override void Move(InputParams _input)
    {
        var tmpPos = this.transform.position;

        if (flag)
        {
            flag = false;
            if (_input.y < 0)
				transform.position += (new Vector3(0,-y_dir,0))* speed; 
			if (_input.y > 0)
                transform.position += (new Vector3(0, y_dir, 0)) * speed; 
			if (_input.x < 0)
                transform.position += (new Vector3(-x_dir, 0, 0)) * speed; 
			if (_input.x > 0)
                transform.position += (new Vector3(x_dir, 0, 0)) * speed; 

            StartCoroutine(WaitTime());
        }
    }

    public void OnDestroy()
    {
       // SoundManager.instance.StopPong();
    }

    IEnumerator WaitTime()//cambia solo dopo essere scesi
    {
        yield return new WaitForSeconds(timeToWait) ;
        flag = true;
    }
}

using UnityEngine;
using System.Collections;

public class InputParams {

	public float x = 0;
	public float y = 0;
	public bool jump = false;
	public bool fire = false;


    public void Clear()
    {
        x = 0;
        y = 0;
        jump = false;
        fire = false;
    }
}

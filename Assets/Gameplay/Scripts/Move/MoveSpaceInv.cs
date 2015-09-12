using UnityEngine;
using System.Collections;

public class MoveSpaceInv : MoveComponent {

    public float speed = 2f;
    public Vector3 direction = Vector3.right;
    private bool canChangeDir = true;
    public Vector3 tmpDir;
    public bool flag = true;
    void Awake()
    {
        direction = Vector3.right;
        direction = Quaternion.AngleAxis(0, Vector3.forward) * direction;
    }

    public override void Move(InputParams _input)
    {
        var tmpPos = this.transform.position;
        
        if (canChangeDir)
        {
            canChangeDir = false;
            StartCoroutine(GoDown());
        }
        if(flag){
            flag = false;
            StartCoroutine(ChangeDir());

        }
       
        

        tmpPos += direction * speed * Time.deltaTime;
        //tmpPos.x += _input.x * speed * Time.deltaTime;
        //tmpPos.y += _input.y * speed * Time.deltaTime;
        this.transform.position = tmpPos;
    }

    IEnumerator GoDown()//cambia solo dopo essere scesi
    {
        yield return new WaitForSeconds(3f);
        tmpDir = direction; // save the old statement
        direction = Vector3.down;
    }

    IEnumerator ChangeDir()//cambia solo dopo essere scesi
    {
        yield return new WaitForSeconds(3.5f);
        if (tmpDir == Vector3.left || tmpDir == Vector3.right)
            direction = -1 * tmpDir;
        flag = true;
        canChangeDir = true;
    }
}

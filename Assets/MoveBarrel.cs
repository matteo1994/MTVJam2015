using UnityEngine;
using System.Collections;

/*
 * Movimento di un barile in stile DonkeyKong
 * è già implementata l'interazione coi muri nel Move
 *
 */

public class MoveBarrel : MoveComponent
{
    
    public float speed = 2f;
    public Vector3 direction = Vector3.right;

    public float deathProbability = 10;

    void Awake()
    {
        direction = Vector3.right;
       // direction = Quaternion.AngleAxis(Random.Range(-15f, 0f), Vector3.forward) * direction;
    }

    public override void Move(InputParams _input)
    {
        var tmpPos = this.transform.position;

        tmpPos.y -= 0.25f * Time.deltaTime;

        //Interazione con il muro (cambio di direzione o morte)
        if (transform.position.x >= ConstVar.X_LIMIT - 1f)
        {
               tmpPos.y -= 3f * Time.deltaTime;
               if (transform.position.x >= ConstVar.X_LIMIT - 0.5f)
               {
                   if (transform.position.x >= ConstVar.X_LIMIT - 0.5f && transform.position.x <= ConstVar.X_LIMIT - 0.4f && Random.Range(0, 100) < deathProbability)
                   {
                       Destroy(this.gameObject);
                       Debug.Log("caco");
                   }
                   else
                       direction.x = -1;
               }
        }
        else if (transform.position.x <= -1*(ConstVar.X_LIMIT - 1f))
        {
            tmpPos.y -= 3f * Time.deltaTime;
            if (transform.position.x <= -1*(ConstVar.X_LIMIT - 0.5f))
            {
                if (transform.position.x == -1 * (ConstVar.X_LIMIT - 0.5f) && transform.position.x == -1 * (ConstVar.X_LIMIT - 0.4f) && Random.Range(0, 100) < deathProbability)
                {
                    Destroy(this.gameObject);
                    Debug.Log("caco");
                }
                else
                    direction.x = 1;
            }
        }

        //Interazioni con il limite inferiore della scena
        //if (transform.position.y <= -1*(ConstVar.Y_LIMIT - 0.5f))
        //{
        //Destroy(this.gameObject);
        // }

        //normal flow
        tmpPos += direction * speed * Time.deltaTime;
        this.transform.position = tmpPos;
    }

   
}


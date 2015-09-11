using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
    public bool isDown = false;
    public bool isUp = false;

    //float x_limit = 11f;
    float y_limit = 7.5f;

    void Update () {
        if (isUp)
            if (transform.position.y > y_limit)
                Destroy(this.gameObject);// GetComponent<AbstractCharacter>().direction.y *= -1;
        if (isDown)
            if (transform.position.y < -y_limit)
                Destroy(this.gameObject);
    } 
}

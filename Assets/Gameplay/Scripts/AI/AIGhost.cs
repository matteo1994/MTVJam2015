using UnityEngine;
using System.Collections;

public abstract class AIGhost : AIComponent {

    public override void GetInput(InputParams _input)
    {
        var distance = (AbstractCharacter.mainCharacter.transform.position - transform.position);
        _input.Clear();
        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
            _input.x = Mathf.Sign(distance.x);
        else
            _input.y = Mathf.Sign(distance.y);
    }

}

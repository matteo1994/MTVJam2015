using UnityEngine;
using System.Collections;

public class AIGhost : AIComponent {

    private float t = 1;

    public override void GetInput(InputParams _input)
    { 
        t += Time.deltaTime;

        if (t > 1f)
        {

            float minDist = 1000000000;
            Transform target = null;
            foreach (var pl in GameController.Instance.playerController.currentPlayers)
            {
                if (pl == null) continue;
                float distance = (pl.transform.position - transform.position).magnitude;
                if (distance < minDist)
                {
                    minDist = distance;
                    target = pl.transform;
                }
            }

            if (target != null)
            {
                t = 0.0f;
                _input.Clear();
                var dist = target.position - transform.position;
                if (Mathf.Abs(dist.x) > Mathf.Abs(dist.y))
                    _input.x = Mathf.Sign(dist.x);
                else
                    _input.y = Mathf.Sign(dist.y);
            }

        }

    }

}

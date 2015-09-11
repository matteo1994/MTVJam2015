using UnityEngine;
using System.Collections;

using DG.Tweening;

public class MoveLR : MonoBehaviour {

    void Awake()
    {
        Tween t = transform.DOMoveX(10, 0.5f).SetEase(Ease.InOutCirc).SetLoops(-1, LoopType.Yoyo).SetRelative();
        t.Play();
    }
}

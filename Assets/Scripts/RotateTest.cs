using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateTest : MonoBehaviour
{
    public float angle = 0f;
    public Ease ease;
    private Tweener tweener;

    private bool isPause = false;
    private void Start()
    {
        tweener = DOVirtual.Float(0f, 60f, 1f, value =>
        {
            angle = value;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }).SetLoops(-1, LoopType.Yoyo).SetEase(ease);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isPause)
            {
                tweener.Pause();
            }
            else
            {
                tweener.Play();
            }
            isPause = !isPause;
        }
    }
}

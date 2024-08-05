using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _xRotation;

    private void Start()
    {
        transform.DORotate(new Vector3(_xRotation, 0, 0), _duration).SetLoops(-1, LoopType.Restart);
    }
}

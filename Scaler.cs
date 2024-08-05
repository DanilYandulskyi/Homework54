using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _finalScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        DOTween.Sequence()
            .Append(transform.DOScale(_finalScale, _duration))
            .Append(transform.DOScale(Vector3.one, _duration)).SetLoops(-1, LoopType.Restart);
    }
}
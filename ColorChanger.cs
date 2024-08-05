using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private float _duration;

    private void Start()
    {
        DOTween.Sequence()
        .Append(_image.DOColor(Color.red, _duration))
        .Append(_image.DOColor(Color.black, _duration)).SetLoops(-1, LoopType.Restart);
    }
}

using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        DOTween.Sequence()
            .Append(_text.DOText("Changed", _duration))
            .Append(_text.DOText("Added", _duration).SetRelative())
            .Append(_text.DOText("Hacked", _duration, true, ScrambleMode.All)).SetLoops(-1, LoopType.Restart);
    }
}
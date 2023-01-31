using UnityEngine.Events;
using DG.Tweening;
using UnityEngine;

public class PipeMovement
{
    Transform pipeParent;
    float speed;
    UnityAction unityAction;

    public PipeMovement(Transform _pipeParent, float _speed,UnityAction _unityAction)
    {
        pipeParent = _pipeParent;
        speed = _speed;
        unityAction = _unityAction;
    }
    public void StartMove()
    {
        pipeParent.DOMoveX(-2, speed).SetEase(Ease.Linear)
        .OnUpdate(() =>
        {
            if (!GameManager.GameManagers.instance.isPlaying)
            {
                pipeParent.DOKill();
            }
        })
        .OnComplete(() =>
        {
            unityAction.Invoke();
        });
    }
}

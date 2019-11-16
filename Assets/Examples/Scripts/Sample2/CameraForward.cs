
using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

public class CameraForward : MonoBehaviour
{
    void Start()
    {
        Tween move = transform.TMove(transform.position,
            transform.position + Vector3.forward * 40, 20f, EaseMode.SmoothStep2);
        move.Play();
    }
}

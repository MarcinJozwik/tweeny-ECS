using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

public class CubeTween : MonoBehaviour
{

    void Start()
    {
        Tween move1 = transform.TMove(transform.position, transform.position + Vector3.up, 1f,
            EaseMode.Bell2);
        Tween rotation1 = transform.TRotate(transform.rotation,
            Quaternion.LookRotation(Vector3.down), 1f, EaseMode.SmoothStart3);
        Tween scale1 = transform.TScale(Vector3.one, Vector3.one * 1.5f, 1f, EaseMode.SmoothStop3);
        Tween scale2 = transform.TScale(Vector3.one * 1.5f, Vector3.one * .2f, .2f, EaseMode.Linear);
        Tween scale3 = transform.TScale(Vector3.one * .2f, Vector3.one * 10f, .2f, EaseMode.SmoothStop3);
        Tween color = GetComponent<Renderer>().material.TColor(Color.white, Color.red, .2f, EaseMode.SmoothStop3);
        
        Timeline timeline = new Timeline();
        timeline.AddGroup(move1, rotation1, scale1);
        timeline.AddDelay(0.5f);
        timeline.AddGroup(scale2);
        timeline.AddGroup(scale3, color);
        timeline.Build();
        timeline.Play();
    }
}

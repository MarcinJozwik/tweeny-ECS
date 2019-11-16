using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

public class CubeTween : MonoBehaviour
{
    private const float minDuration = 4f;
    private const float maxDuration = 5f;
    void Start()
    {
        float duration1 = ShuffleDuration();
        Tween move1 = transform.TMove(transform.position + Vector3.up, duration1, EaseMode.Bell2);
        Tween rotation1 = transform.TRotate(Quaternion.LookRotation(Vector3.down), duration1, EaseMode.SmoothStart3);
        Tween scale1 = transform.TScale(Vector3.one * 1.5f, duration1, EaseMode.SmoothStop3);
        Tween color1 = GetComponent<Renderer>().material.TColor(Color.white, Color.magenta, duration1, EaseMode.Linear);
        
        float duration2 = ShuffleDuration();
        Tween scale2 = transform.TScale(Vector3.one * 1.5f, Vector3.one * .6f, duration2, EaseMode.BouncedBezier7);
        
        float duration3 = ShuffleDuration();
        Tween color3 = GetComponent<Renderer>().material.TColor(Color.magenta, Color.red, duration3, EaseMode.SmoothStop3);
        Tween scale3 = transform.TScale(Vector3.one * .6f, Vector3.one * 2f, duration3, EaseMode.Bell4);

        float duration4 = ShuffleDuration();
        Tween fade4 = GetComponent<Renderer>().material.TFade(0f, duration4, EaseMode.SmoothStop3);
        
        Timeline timeline = new Timeline();
        timeline.AddGroup(move1, rotation1, scale1, color1);
        timeline.AddDelay(maxDuration - duration1);
        timeline.AddGroup(scale2);
        timeline.AddDelay(maxDuration - duration2);
        timeline.AddGroup(scale3, color3);
        timeline.AddDelay(maxDuration - duration3);
        timeline.AddGroup(fade4);
        timeline.Build();
        timeline.Play();
    }

    private float ShuffleDuration()
    {
        return Tweeny.Random(minDuration, maxDuration, EaseMode.Linear);
    }
}

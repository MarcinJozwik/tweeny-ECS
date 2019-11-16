using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

public class PlaneTween : MonoBehaviour
{
    void Start()
    {
        Tween color3 = GetComponent<Renderer>().material.TColor(Color.red, 20f, EaseMode.Linear);
        color3.Play();
    }
}

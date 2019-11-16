using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

public class PlaneTween : MonoBehaviour
{
    void Start()
    {
        Material material = GetComponent<Renderer>().material;
        Tween color3 = material.TColor(material.color, Color.red, 20f, EaseMode.Linear);
        color3.Play();
    }
}

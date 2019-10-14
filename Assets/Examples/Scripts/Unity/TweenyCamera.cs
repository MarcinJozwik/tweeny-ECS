using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

namespace Unity
{
    public class TweenyCamera : MonoBehaviour
    {
        public Camera Camera;
        private Tween tween;
        
        private void Start()
        {
//            tween = Camera.TCameraSize(0, 14.5f, 1f, EaseMode.SmoothStart3);

            tween = Camera.TCameraFieldOfView(1, 60, 1f, EaseMode.SmoothStop5);
            tween.Play();
        }
    }
}
using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

namespace Unity
{
    public class TweenyLineRenderer : MonoBehaviour
    {
        public LineRenderer Line;
        
        [Range(0,9)]
        public int mode;
        
        private void Start()
        {
            Ease ease = TweenyExamples.GetEase(mode);
            float duration = 5f;
            
            var tween = Line.TStartColor(Color.white, Color.red, duration, EaseMode.SmoothStep5);
            var tween2 = Line.TEndColor(Color.white, Color.blue, duration, ease);
            var tween3 = Line.TEndWidth(0.1f, .5f, duration, ease);
            var tween4 = Line.TStartWidth(.3f, 1, duration, ease);

            Timeline timeline = new Timeline();
            timeline.AddGroup(tween, tween2);
            timeline.AddDelay(3f);
            timeline.AddGroup(tween3, tween4);
            timeline.Build();
            timeline.Play();
        }
    }
}
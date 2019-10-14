using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.ECS.Utilities;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

namespace Unity
{
    public class EntitasObject : MonoBehaviour
    {
        [Range(0,9)]
        public int EaseMode;

        private Ease ease;
        private float duration;

        private Vector3 startPosition;
        private Vector3 endPosition;
        
        private Material material;
        private float startAlpha;
        private float endAlpha;

        private Vector3 startScale;
        private Vector3 endScale;

        private Tween move;
        private Tween scale;
        private Tween fade;

        private Timeline timeline;
        
        private void Start()
        {
            duration = GetComponentInParent<Duration>().DurationTime;
            ease = TweenyExamples.GetEase(EaseMode);

            //T Move
            startPosition = transform.position;
            endPosition = startPosition + transform.forward * 40f;
            
            //T Fade
            material = GetComponent<Renderer>().material;
            startAlpha = 0;
            endAlpha = material.color.a;
            
            //T Scale
            startScale = transform.localScale;
            endScale = startScale * 2f;
            
            PrepareTween();
        }

        private void PrepareTween()
        {
            move = transform.TMove(startPosition, endPosition, duration, ease, new TweenSet()
                .OnStart((() => Print("Start Move")))
                .OnComplete((() => Print("Complete Move")))
                .OnLoopComplete((() => Print("Complete Loop Move")))
//                .SetLoops(2, LoopType.PingPong, .5f)
//                .Reverse()
            );

            scale = transform.TScale(startScale, endScale, duration, ease, new TweenSet()
                .OnStart((() => Print("Start scale")))
                .OnComplete((() => Print("Complete scale")))
                .OnLoopComplete((() => Print("Complete Loop scale")))
            );
            
            fade = material.TFade(startAlpha, endAlpha, duration, ease,
            new TweenSet()
                .OnStart((() => Print("Start fade")))
                .OnComplete((() => Print("Complete fade")))
                .OnLoopComplete((() => Print("Complete Loop fade")))
                .Reverse()
            );
            
            timeline = new Timeline();
            timeline.AddGroup(scale, move);
            timeline.AddDelay(2f,new TweenSet()
                .OnStart((() => Print("Start Delay")))
                .OnComplete((() => Print("Complete Delay")))
                .OnLoopComplete((() => Print("Complete Loop Delay"))));
            timeline.AddGroup(fade);
            timeline.Build(new TweenSet()
                .SetDelay(.1f)
                .OnStart((() => Print("Start Timeline")))
                .OnComplete((() => Print("Complete Timeline")))
                .Reverse()
            );

//            Debug.Log($"Timeline duration:{timeline.GetTotalDuration()}s");
        }

        private void Print(string message)
        {
            Debug.Log(message);
        }
        
        private void PrintStartMessage()
        {
            Debug.Log("Tween started");
        }

        private void PrintLoopMessage()
        {
            Debug.Log("Tween loop completed");
        }
        
        private void PrintMessage()
        {
            Debug.Log("Tween completed");
        }

        public void Tween()
        {
            timeline.Play();
        }

        public void Stop()
        {
            timeline.Stop();
        }

        public void Reset()
        {
            timeline.Reset();
        }
    }
}
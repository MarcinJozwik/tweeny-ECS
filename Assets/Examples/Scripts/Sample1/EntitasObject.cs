using System;
using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
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
        
        private Color startColor;
        private Color endColor;

        private Vector3 startScale;
        private Vector3 endScale;

        private Quaternion startRotation;
        private Quaternion endRotation;

        private Tween move;
        private Tween scale;
        private Tween fade;
        private Tween rotate;
        private Tween color;

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
            endScale = startScale * 1.8f;
            
            //T Color
            startColor = Color.yellow;
            endColor = Color.magenta;
            
            //T Rotate
            startRotation = transform.rotation;
            endRotation = Quaternion.Euler(90, 90, 180);
            
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

            rotate = transform.TRotate(startRotation, endRotation, duration, ease);

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

            color = material.TColor(startColor, endColor, duration, ease);
            
            
            timeline = new Timeline();
            timeline.AddGroup(scale, move, color, rotate);
            timeline.AddDelay(2f,new TweenSet()
                .OnStart((() => Print("Start Delay")))
                .OnComplete((() => Print("Complete Delay")))
                .OnLoopComplete((() => Print("Complete Loop Delay"))));
            timeline.AddGroup(fade);
            timeline.Build(new TweenSet()
//                .SetDelay(2f)
                .OnStart((() => Print("Start Timeline")))
                .OnComplete((() => Print("Complete Timeline")))
//                .Reverse()
            );

            Debug.Log($"Timeline duration:{timeline.GetTotalDuration()}s");
        }

//        private void Update()
//        {
//            Debug.Log($"Timeline is Playing:{timeline.IsPlaying()}");
//            Debug.Log($"Timeline is Finished:{timeline.IsFinished()}");
//        }

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

        public void Play()
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

        public void GoTo(float step)
        {
            timeline.GoTo(step);
        }
    }
}
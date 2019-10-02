using TweenyPlugin;
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
            move = transform.TMove(startPosition, endPosition, duration, ease).OnComplete(PrintMessage).SetLoops(2, LoopType.Reverse);
            scale = transform.TScale(startScale, endScale, duration, ease).Reverse();
            fade = material.TFade(startAlpha, endAlpha, duration, ease).SetLoops(3).OnLoopComplete(PrintLoopMessage);
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
            move.Play();     
            scale.Play();     
            fade.Play();     
        }

        public void Stop()
        {
            move.Stop();     
            scale.Stop();     
            fade.Stop();   
        }
    }
}
using TweenyPlugin;
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

        private Vector3 startScale;
        private Vector3 endScale;

        private TweenLink link;
        
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
            link = Tweeny.TMove(transform, startPosition, endPosition, duration, ease);
            link.OnComplete((() => { Debug.Log("Tween completed"); }));
//            Tweeny.TMove(transform, startPosition, endPosition, duration, TweenyTest.GetEase(mode));
//            Tweeny.TScale(transform, startScale, endScale, duration, TweenyTest.GetEase(mode));
//            Tweeny.TFade(material, startAlpha, endAlpha, duration, TweenyTest.GetEase(mode));
        }

        public void Reset()
        {
            link.Destroy();
            transform.position = startPosition;
            PrepareTween();
        }
        
        public void Tween()
        {
            link.Play();     
        }

        public void Stop()
        {
            link.Stop();
        }
    }
}
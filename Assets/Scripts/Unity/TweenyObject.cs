using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class TweenyObject : MonoBehaviour
    {
        private int mode;
        private float duration;

        private Vector3 startPosition;
        private Vector3 endPosition;
        
        private Material material;
        private float startAlpha;
        private float endAlpha;

        private void Start()
        {
            duration = GetComponentInParent<Duration>().DurationTime;
            mode = GetComponent<Mode>().EaseMode;

            //T Move
            startPosition = transform.position;
            endPosition = startPosition + transform.forward * 40f;
            
            //T Fade
            material = GetComponent<Renderer>().material;
            startAlpha = 0;
            endAlpha = material.color.a;
        }
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TweenyCollector.Register(new TMove(transform, startPosition, endPosition, duration, TweenyTest.GetEase(mode)));
                TweenyCollector.Register(new TFade(material, startAlpha, endAlpha, duration, TweenyTest.GetEase(mode)));
            }
        }
    }
}

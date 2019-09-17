using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class EntitasObject : MonoBehaviour
    {
        private int mode;
        private float duration;

        private Vector3 startPosition;
        private Vector3 endPosition;
        
        private Material material;
        private float startAlpha;
        private float endAlpha;

        private Vector3 startScale;
        private Vector3 endScale;

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
            
            //T Scale
            startScale = transform.localScale;
            endScale = startScale * 2f;
        }
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Tweeny.TMove(transform, startPosition, endPosition, duration, TweenyTest.GetEase(mode));
            }
        }
    }
}
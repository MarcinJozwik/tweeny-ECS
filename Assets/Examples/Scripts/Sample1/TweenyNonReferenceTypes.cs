using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using TweenyPlugin.Utilities;
using UnityEngine;

namespace Unity
{
    public class TweenyNonReferenceTypes : MonoBehaviour
    {
        public Light Light;
        private TweenyFloat tweenyFloat;
        private TweenyVector3 tweenyVector3;
        private TweenyColor tweenyColor;
        
        private void Start()
        {
            tweenyFloat = new TweenyFloat();
            Tween tween = tweenyFloat.TFloat(0, 3, 10f, EaseMode.SmoothStop4);
            tween.Play();
            
            tweenyVector3 = new TweenyVector3();
            Tween tween2 = tweenyVector3.TVector3(transform.position + new Vector3(40,0,0),
                transform.position, 10, EaseMode.SmoothStart2);
            tween2.Play();
            
            tweenyColor = new TweenyColor();
            Tween tween3 = tweenyColor.TColor(Color.red, Color.white, 10, EaseMode.Linear);
            tween3.Play();
        }

        private void Update()
        {
            Light.intensity = tweenyFloat.Value;
            Light.color = tweenyColor.Value;
            transform.position = tweenyVector3.Value;
        }
    }
}
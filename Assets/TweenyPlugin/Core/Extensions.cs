using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using TweenyPlugin.Utilities;
using UnityEngine;

namespace TweenyPlugin.Core
{
    public static partial class Extensions
    {
        public static Tween TMove(this Transform transform, Vector3 startPosition,
            Vector3 endPosition, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformMove(transform, startPosition, endPosition, duration, ease, set);
        }

        public static Tween TRotate(this Transform transform, Quaternion startRotation,
            Quaternion endRotation, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformRotate(transform, startRotation, endRotation, duration, ease, set);
        }
        
        public static Tween TRotate(this Transform transform, Vector3 startRotation,
            Vector3 endRotation, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformRotate(transform, startRotation, endRotation, duration, ease, set);
        }

        public static Tween TScale(this Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformScale(transform, startScale, endScale, duration, ease, set);
        }

        public static Tween TFade(this Material material, float startAlpha, float endAlpha,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TMaterialFade(material, startAlpha, endAlpha, duration, ease, set);
        }

        public static Tween TColor(this Material material, Color startColor, Color endColor,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TMaterialColor(material, startColor, endColor, duration, ease, set);
        }

        public static Tween TOrtographicSize(this Camera camera, float startSize, float endSize,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TCameraSize(camera, startSize, endSize, duration, ease, set);
        }
        
        public static Tween TFieldOfView(this Camera camera, float startFov, float endFov,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TCameraFieldOfView(camera, startFov, endFov, duration, ease, set);
        }
        
        public static Tween TFloat(this TweenyFloat tweenyFloat, float startValue, float endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TFloat(tweenyFloat, startValue, endValue, duration, ease, set);
        }
        
        public static Tween TDouble(this TweenyDouble tweenyDouble, double startValue, double endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TDouble(tweenyDouble, startValue, endValue, duration, ease, set);
        }
        
        public static Tween TVector2(this TweenyVector2 tweenyVector2, Vector2 startValue, Vector2 endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TVector2(tweenyVector2, startValue, endValue, duration, ease, set);
        }
        
        public static Tween TVector3(this TweenyVector3 tweenyVector3, Vector3 startValue, Vector3 endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TVector3(tweenyVector3, startValue, endValue, duration, ease, set);
        }

        public static Tween TColor(this TweenyColor tweenyColor, Color startValue, Color endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TColor(tweenyColor, startValue, endValue, duration, ease, set);
        }

        public static Tween TSpotAngle(this Light light, float startAngle, float endAngle,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightSpotAngle(light, startAngle, endAngle, duration, ease, set);
        }

        public static Tween TFade(this Light light, float startAlpha, float endAlpha,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightFade(light, startAlpha, endAlpha, duration, ease, set);
        }

        public static Tween TRange(this Light light, float startRange, float endRange,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightRange(light, startRange, endRange, duration, ease, set);
        }

        public static Tween TIntensity(this Light light, float startIntensity, float endIntensity,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightIntensity(light, startIntensity, endIntensity, duration, ease, set);
        }

        public static Tween TColor(this Light light, Color startColor, Color endColor,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightColor(light, startColor, endColor, duration, ease, set); 
        }

        public static Tween TStartWidth(this LineRenderer line, float startWidth,
            float endWidth, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererStartWidth(line, startWidth, endWidth, duration, ease, set);
        }
        
        public static Tween TEndWidth(this LineRenderer line, float startWidth,
            float endWidth, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererEndWidth(line, startWidth, endWidth, duration, ease, set);
        }

        public static Tween TStartColor(this LineRenderer line, Color startColor,
            Color endColor, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererStartColor(line, startColor, endColor, duration, ease, set);
        }
        
        public static Tween TEndColor(this LineRenderer line, Color startColor,
            Color endColor, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererEndColor(line, startColor, endColor, duration, ease, set);
        }
    }
}
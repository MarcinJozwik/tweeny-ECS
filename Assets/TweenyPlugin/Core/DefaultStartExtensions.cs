using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using TweenyPlugin.Utilities;
using UnityEngine;

namespace TweenyPlugin.Core
{
    public static partial class Extensions
    {
        public static Tween TMove(this Transform transform,
            Vector3 endPosition, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformMove(transform, transform.position, endPosition, duration, ease, set);
        }

        public static Tween TRotate(this Transform transform,
            Quaternion endRotation, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformRotate(transform, transform.rotation, endRotation, duration, ease, set);
        }
        
        public static Tween TRotate(this Transform transform,
            Vector3 endRotation, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformRotate(transform, transform.rotation.eulerAngles, endRotation, duration, ease, set);
        }

        public static Tween TScale(this Transform transform, Vector3 endScale,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TTransformScale(transform, transform.localScale, endScale, duration, ease, set);
        }

        public static Tween TMove(this RectTransform rectTransform,
            Vector2 endPosition, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TRectTransformMove(rectTransform, rectTransform.position, endPosition, duration,
                ease, set);
        }

        public static Tween TFade(this Material material, float endAlpha,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TMaterialFade(material, material.color.a, endAlpha, duration, ease, set);
        }

        public static Tween TColor(this Material material, Color endColor,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TMaterialColor(material, material.color, endColor, duration, ease, set);
        }

        public static Tween TOrtographicSize(this Camera camera, float endSize,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TCameraSize(camera, camera.orthographicSize, endSize, duration, ease, set);
        }
        
        public static Tween TFieldOfView(this Camera camera, float endFov,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TCameraFieldOfView(camera, camera.fieldOfView, endFov, duration, ease, set);
        }
        
        public static Tween TFloat(this TweenyFloat tweenyFloat, float endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TFloat(tweenyFloat, tweenyFloat.Value, endValue, duration, ease, set);
        }
        
        public static Tween TDouble(this TweenyDouble tweenyDouble, double endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TDouble(tweenyDouble, tweenyDouble.Value, endValue, duration, ease, set);
        }
        
        public static Tween TVector2(this TweenyVector2 tweenyVector2, Vector2 endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TVector2(tweenyVector2, tweenyVector2.Value, endValue, duration, ease, set);
        }
        
        public static Tween TVector3(this TweenyVector3 tweenyVector3, Vector3 endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TVector3(tweenyVector3, tweenyVector3.Value, endValue, duration, ease, set);
        }

        public static Tween TColor(this TweenyColor tweenyColor, Color endValue,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TColor(tweenyColor, tweenyColor.Value, endValue, duration, ease, set);
        }

        public static Tween TSpotAngle(this Light light, float endAngle,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightSpotAngle(light, light.spotAngle, endAngle, duration, ease, set);
        }

        public static Tween TFade(this Light light, float endAlpha,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightFade(light, light.color.a, endAlpha, duration, ease, set);
        }

        public static Tween TRange(this Light light, float endRange,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightRange(light, light.range, endRange, duration, ease, set);
        }

        public static Tween TIntensity(this Light light, float endIntensity,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightIntensity(light, light.intensity, endIntensity, duration, ease, set);
        }

        public static Tween TColor(this Light light, Color endColor,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLightColor(light, light.color, endColor, duration, ease, set); 
        }

        public static Tween TStartWidth(this LineRenderer line,
            float endWidth, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererStartWidth(line, line.startWidth, endWidth, duration, ease, set);
        }
        
        public static Tween TEndWidth(this LineRenderer line,
            float endWidth, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererEndWidth(line, line.endWidth, endWidth, duration, ease, set);
        }

        public static Tween TStartColor(this LineRenderer line,
            Color endColor, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererStartColor(line, line.startColor, endColor, duration, ease, set);
        }
        
        public static Tween TEndColor(this LineRenderer line,
            Color endColor, float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TLineRendererEndColor(line, line.endColor, endColor, duration, ease, set);
        }
    }
}
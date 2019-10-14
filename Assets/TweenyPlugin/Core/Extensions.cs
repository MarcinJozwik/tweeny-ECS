using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using TweenyPlugin.Utilities;
using UnityEngine;

namespace TweenyPlugin.Core
{
    public static partial class Extensions
    {
        public static Tween TMove(this Transform transform, Vector3 startPosition,
            Vector3 endPosition, float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TMove(transform, startPosition, endPosition, duration, ease, tweenSet);
        }

        public static Tween TScale(this Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TScale(transform, startScale, endScale, duration, ease, tweenSet);
        }

        public static Tween TFade(this Material material, float startAlpha, float endAlpha,
            float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TFade(material, startAlpha, endAlpha, duration, ease, tweenSet);
        }

        public static Tween TCameraSize(this Camera camera, float startSize, float endSize,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TCameraSize(camera, startSize, endSize, duration, ease, set);
        }
        
        public static Tween TCameraFieldOfView(this Camera camera, float startFov, float endFov,
            float duration, Ease ease, TweenSet set = null)
        {
            return Tweeny.TCameraFieldOfView(camera, startFov, endFov, duration, ease, set);
        }
        
        public static Tween TFloat(this TweenyFloat tweenyFloat, float startValue, float endValue,
            float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TFloat(tweenyFloat, startValue, endValue, duration, ease, tweenSet);
        }
        
        public static Tween TDouble(this TweenyDouble tweenyDouble, double startValue, double endValue,
            float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TDouble(tweenyDouble, startValue, endValue, duration, ease, tweenSet);
        }
        
        public static Tween TVector2(this TweenyVector2 tweenyVector2, Vector2 startValue, Vector2 endValue,
            float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TVector2(tweenyVector2, startValue, endValue, duration, ease, tweenSet);
        }
        
        public static Tween TVector3(this TweenyVector3 tweenyVector3, Vector3 startValue, Vector3 endValue,
            float duration, Ease ease, TweenSet tweenSet = null)
        {
            return Tweeny.TVector3(tweenyVector3, startValue, endValue, duration, ease, tweenSet);
        }
    }
}
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using TweenyPlugin.Utilities;
using UnityEngine;

namespace TweenyPlugin.Core
{
    public partial class Tweeny
    {
        public static Tween TBase(float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            return GetTween(entity);
        }
        
        public static float GetValue(float time, float min, float max, Ease ease)
        {
            time = time / (max - min);
            return ease.Get(time);
        }

        public static float Random(float min, float max, Ease ease)
        {
            float value =  ease.Get(UnityEngine.Random.value);
            return min + (value * (max - min));
        }

        public static Tween TMove(Transform transform, Vector3 startPosition,
            Vector3 endPosition, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTransform(transform);
            entity.AddMove(startPosition, (endPosition - startPosition).normalized,
                Vector3.Distance(endPosition, startPosition));
            return GetTween(entity);
        }
        
        public static Tween TScale(Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTransform(transform);
            entity.AddScale(startScale, (endScale - startScale));
            return GetTween(entity);
        }

        public static Tween TFade(Material material, float startAlpha, float endAlpha, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddMaterial(material);
            entity.AddFade(startAlpha, endAlpha);
            return GetTween(entity);
        }

        public static Tween TCameraSize(Camera camera, float startSize, float endSize,
            float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddCamera(camera);
            entity.AddCameraSize(startSize, endSize);
            return GetTween(entity);
        }
        
        public static Tween TCameraFieldOfView(Camera camera, float startFov, float endFov, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddCamera(camera);
            entity.AddCameraFieldOfView(startFov, endFov);
            return GetTween(entity);
        }

        public static Tween TFloat(TweenyFloat tweenyFloat, float startValue, float endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddFloat(tweenyFloat, startValue, endValue);
            return GetTween(entity);
        }

        public static Tween TDouble(TweenyDouble tweenyDouble, double startValue, double endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddDouble(tweenyDouble, startValue, endValue);
            return GetTween(entity);
        }

        public static Tween TVector2(TweenyVector2 tweenyVector2, Vector2 startValue, Vector2 endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddVector2(tweenyVector2, startValue, endValue);
            return GetTween(entity);
        }

        public static Tween TVector3(TweenyVector3 tweenyVector3, Vector3 startValue, Vector3 endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddVector3(tweenyVector3, startValue, endValue);
            return GetTween(entity);
        }
    }
}
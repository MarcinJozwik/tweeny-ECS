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
            entity.AddVector3(Vector3.zero, startPosition, endPosition);
            entity.isMove = true;
            return GetTween(entity);
        }
        
        public static Tween TScale(Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTransform(transform);
            entity.AddVector3(Vector3.zero, startScale, endScale);
            entity.isScale = true;
            return GetTween(entity);
        }

        public static Tween TMaterialFade(Material material, float startAlpha, float endAlpha, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddMaterial(material);
            entity.AddFloat(0, startAlpha, endAlpha);
            entity.isFade = true;
            return GetTween(entity);
        }

        public static Tween TCameraSize(Camera camera, float startSize, float endSize,
            float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddCamera(camera);
            entity.AddFloat(0, startSize, endSize);
            entity.isCameraSize = true;
            return GetTween(entity);
        }
        
        public static Tween TCameraFieldOfView(Camera camera, float startFov, float endFov, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddCamera(camera);
            entity.AddFloat(0, startFov, endFov);
            entity.isCameraFieldOfView = true;
            return GetTween(entity);
        }

        public static Tween TMaterialColor(Material material, Color startColor, Color endColor, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddMaterial(material);
            entity.AddColor(Color.white, startColor, endColor);
            return GetTween(entity);
        }

        public static Tween TFloat(TweenyFloat tweenyFloat, float startValue, float endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTweenyFloat(tweenyFloat);
            entity.AddFloat(0, startValue, endValue);
            return GetTween(entity);
        }

        public static Tween TDouble(TweenyDouble tweenyDouble, double startValue, double endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTweenyDouble(tweenyDouble);
            entity.AddDouble(0, startValue, endValue);
            return GetTween(entity);
        }

        public static Tween TVector2(TweenyVector2 tweenyVector2, Vector2 startValue, Vector2 endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTweenyVector2(tweenyVector2);
            entity.AddVector2(Vector2.zero, startValue, endValue);
            return GetTween(entity);
        }

        public static Tween TVector3(TweenyVector3 tweenyVector3, Vector3 startValue, Vector3 endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTweenyVector3(tweenyVector3);
            entity.AddVector3(Vector3.zero, startValue, endValue);
            return GetTween(entity);
        }
        
        public static Tween TColor(TweenyColor tweenyColor, Color startValue, Color endValue, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddTweenyColor(tweenyColor);
            entity.AddColor(Color.white, startValue, endValue);
            return GetTween(entity);
        }
        
        public static Tween TLightColor(Light light, Color startColor, Color endColor, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddLight(light);
            entity.AddColor(Color.white, startColor, endColor);
            return GetTween(entity);
        }
        
        public static Tween TLightIntensity(Light light, float startIntensity, float endIntensity, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddLight(light);
            entity.AddFloat(0, startIntensity, endIntensity);
            entity.isLightIntensity = true;
            return GetTween(entity);
        }
        
        public static Tween TLightRange(Light light, float startRange, float endRange, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddLight(light);
            entity.AddFloat(0, startRange, endRange);
            entity.isLightRange = true;
            return GetTween(entity);
        }
        
        public static Tween TLightSpotAngle(Light light, float startAngle, float endAngle, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddLight(light);
            entity.AddFloat(0, startAngle, endAngle);
            entity.isLightSpotAngle = true;
            return GetTween(entity);
        }
        
        public static Tween TLightFade(Light light, float startAlpha, float endAlpha, float duration, Ease ease, TweenSet set = null)
        {
            TweenyEntity entity = CreateBase(duration, ease, set);
            entity.AddLight(light);
            entity.AddFloat(0, startAlpha, endAlpha);
            entity.isFade = true;
            return GetTween(entity);
        }
    }
}
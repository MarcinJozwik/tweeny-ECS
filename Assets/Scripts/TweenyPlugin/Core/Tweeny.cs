using TweenyPlugin.TweenSystems;
using UnityEngine;

namespace TweenyPlugin
{
    public static class Tweeny
    {
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

        public static Tween Add(Tween tween)
        {
            TweenyCollector.Register(tween);
            return tween;
        }

        public static TweenLink TMove(Transform transform, Vector3 startPosition,
            Vector3 endPosition, float duration, Ease ease)
        {
            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
            entity.AddTransform(transform);
            entity.AddTimer(0f, duration);
            entity.AddEase(ease, 0f);
            entity.AddMove(startPosition, (endPosition - startPosition).normalized,
                Vector3.Distance(endPosition, startPosition));
//            entity.isTweening = true;
            
            var link = new TweenLink(entity);
            return link;
        }
        
        public static void TScale(Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease)
        {
//            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
//            entity.AddTransform(transform);
//            entity.AddTimer(0f, duration);
//            entity.AddEase(ease, 0f);
//            entity.AddScale(startScale, (endScale - startScale));
//            entity.isTweening = true;
        }

        public static void TFade(Material material, float startAlpha, float endAlpha, float duration, Ease ease)
        {
//            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
//            entity.AddTimer(0f, duration);
//            entity.AddEase(ease, 0f);
//            entity.AddMaterial(material);
//            entity.AddFade(startAlpha, endAlpha);
//            entity.isTweening = true;
        }
    }
}
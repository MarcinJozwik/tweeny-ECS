namespace TweenyPlugin
{
    public static class Tweeny
    {
        public static float GetValue(float time, float min, float max, Ease ease)
        {
            time = time / (max - min);
            return ease.EaseMethod.Get(time);
        }
        
        public static float Random(float min, float max, Ease ease)
        {
            float value =  ease.EaseMethod.Get(UnityEngine.Random.Range(min,max));
            return min + (value * (max - min));
        }
    }
}
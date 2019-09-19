using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class SmoothStop : IEasing
    {
        private readonly Ease smoothStart;
        public SmoothStop(Ease smoothStart)
        {
            this.smoothStart = smoothStart;
        }

        public float Get(float time)
        {
            float value = time;
            value = EaseMode.Flip.Get(value);
            value = smoothStart.Get(value);
            value = EaseMode.Flip.Get(value);
            return value;
        }
    }
}
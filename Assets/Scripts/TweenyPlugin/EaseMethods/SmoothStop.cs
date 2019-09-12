namespace TweenyPlugin
{
    public class SmoothStop : AGetEase
    {
        private readonly Ease smoothStart;
        public SmoothStop(Ease smoothStart)
        {
            this.smoothStart = smoothStart;
        }

        public override float Get(float time)
        {
            float value = time;
            value = EaseMode.Flip.EaseMethod.Get(value);
            value = smoothStart.EaseMethod.Get(value);
            value = EaseMode.Flip.EaseMethod.Get(value);
            return value;
        }
    }
}
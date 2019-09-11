namespace TweenyPlugin.EaseMethods
{
    public class ReverseScale : AEase
    {
        private readonly AEase ease;

        public ReverseScale(AEase ease)
        {
            this.ease = ease;
        }

        public override float Get(float time)
        {
            return ease.Get(time) * (1 - time);
        }

    }
}
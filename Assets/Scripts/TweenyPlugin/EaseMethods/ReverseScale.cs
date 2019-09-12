namespace TweenyPlugin.EaseMethods
{
    public class ReverseScale : AGetEase
    {
        private readonly AGetEase getEase;

        public ReverseScale(Ease ease)
        {
            this.getEase = ease.EaseMethod;
        }
        
        public ReverseScale(AGetEase getEase)
        {
            this.getEase = getEase;
        }

        public override float Get(float time)
        {
            return getEase.Get(time) * (1 - time);
        }

    }
}
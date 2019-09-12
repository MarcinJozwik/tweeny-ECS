namespace TweenyPlugin
{
    public class Bounce : AGetEase
    {
        private readonly AGetEase getEase;

        public Bounce(Ease ease)
        {
            this.getEase = ease.EaseMethod;
        }
        
        public Bounce(AGetEase getEase)
        {
            this.getEase = getEase;
        }

        public override float Get(float time)
        {
            float value = getEase.Get(time);
            
            if (value < 0f)
            {
                return -value;
            }

            if (value > 1f)
            {
                return 1f - (value - 1f);
            }

            return value;
        }
    }
}
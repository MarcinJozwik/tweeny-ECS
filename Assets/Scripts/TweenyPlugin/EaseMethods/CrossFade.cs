namespace TweenyPlugin
{
    public class CrossFade : AGetEase
    {
        private readonly AGetEase getEaseA;
        private readonly AGetEase getEaseB;

        public CrossFade(Ease easeA, Ease easeB)
        {
            this.getEaseA = easeA.EaseMethod;
            this.getEaseB = easeB.EaseMethod;
        }
        
        public CrossFade(AGetEase getEaseA, AGetEase getEaseB)
        {
            this.getEaseA = getEaseA;
            this.getEaseB = getEaseB;
        }
        
        public override float Get(float time)
        {
            return (getEaseA.Get(time) * (1 - time)) + (getEaseB.Get(time) * time);
        }
    }
}
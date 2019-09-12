namespace TweenyPlugin
{
    public class Multiply : AGetEase
    {
        private readonly AGetEase getEaseA;
        private readonly AGetEase getEaseB;

        public Multiply(Ease easeA, Ease easeB)
        {
            this.getEaseA = easeA.EaseMethod;
            this.getEaseB = easeB.EaseMethod;
        }
        
        public Multiply(AGetEase getEaseA, AGetEase getEaseB)
        {
            this.getEaseA = getEaseA;
            this.getEaseB = getEaseB;
        }
        
        public override float Get(float time)
        {
            return getEaseA.Get(time) * getEaseB.Get(time);
        }
    }
}
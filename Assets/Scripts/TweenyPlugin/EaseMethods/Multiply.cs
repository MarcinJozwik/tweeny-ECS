namespace TweenyPlugin
{
    public class Multiply : AEase
    {
        private readonly AEase easeA;
        private readonly AEase easeB;

        public Multiply(AEase easeA, AEase easeB)
        {
            this.easeA = easeA;
            this.easeB = easeB;
        }
        
        public override float Get(float time)
        {
            return easeA.Get(time) * easeB.Get(time);
        }
    }
}
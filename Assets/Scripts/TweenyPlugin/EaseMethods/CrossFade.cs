namespace TweenyPlugin
{
    public class CrossFade : AEase
    {
        private readonly AEase easeA;
        private readonly AEase easeB;

        public CrossFade(AEase easeA, AEase easeB)
        {
            this.easeA = easeA;
            this.easeB = easeB;
        }
        
        public override float Get(float time)
        {
            return (easeA.Get(time) * (1 - time)) + (easeB.Get(time) * time);
        }
    }
}
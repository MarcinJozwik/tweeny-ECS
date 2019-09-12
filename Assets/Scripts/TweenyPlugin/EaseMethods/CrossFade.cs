namespace TweenyPlugin
{
    public class CrossFade : IEasing
    {
        private readonly Ease getEaseA;
        private readonly Ease getEaseB;

        public CrossFade(Ease easeA, Ease easeB)
        {
            this.getEaseA = easeA;
            this.getEaseB = easeB;
        }

        public float Get(float time)
        {
            return (getEaseA.Get(time) * (1 - time)) + (getEaseB.Get(time) * time);
        }
    }
}
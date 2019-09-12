namespace TweenyPlugin
{
    public class Multiply : IEasing
    {
        private readonly Ease easeA;
        private readonly Ease easeB;

        public Multiply(Ease easeA, Ease easeB)
        {
            this.easeA = easeA;
            this.easeB = easeB;
        }

        public float Get(float time)
        {
            return easeA.Get(time) * easeB.Get(time);
        }
    }
}
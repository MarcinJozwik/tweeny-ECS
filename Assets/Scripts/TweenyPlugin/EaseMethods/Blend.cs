namespace TweenyPlugin
{
    public class Blend : IEasing
    {
        //range [0;1]
        private readonly float blend;
        private readonly Ease getEaseA;
        private readonly Ease getEaseB;

        public Blend(Ease easeA, Ease easeB, float blend)
        {
            this.getEaseA = easeA;
            this.getEaseB = easeB;
            this.blend = blend;
        }

        public float Get(float time)
        {
            return (getEaseA.Get(time) * (1 - blend)) + (getEaseB.Get(time) * blend);
        }
    }
}
namespace TweenyPlugin
{
    public class Blend : AEase
    {
        //range [0;1]
        private readonly float blend;
        private readonly AEase easeA;
        private readonly AEase easeB;

        public Blend(AEase easeA, AEase easeB, float blend)
        {
            this.easeA = easeA;
            this.easeB = easeB;
            this.blend = blend;
        }

        public override float Get(float time)
        {
            return (easeA.Get(time) * (1 - blend)) + (easeB.Get(time) * blend);
        }
    }
}
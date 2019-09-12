namespace TweenyPlugin
{
    public class Blend : AGetEase
    {
        //range [0;1]
        private readonly float blend;
        private readonly AGetEase getEaseA;
        private readonly AGetEase getEaseB;

        public Blend(Ease easeA, Ease easeB, float blend)
        {
            this.getEaseA = easeA.EaseMethod;
            this.getEaseB = easeB.EaseMethod;
            this.blend = blend;
        }
        
        public Blend(AGetEase getEaseA, AGetEase getEaseB, float blend)
        {
            this.getEaseA = getEaseA;
            this.getEaseB = getEaseB;
            this.blend = blend;
        }

        public override float Get(float time)
        {
            return (getEaseA.Get(time) * (1 - blend)) + (getEaseB.Get(time) * blend);
        }
    }
}
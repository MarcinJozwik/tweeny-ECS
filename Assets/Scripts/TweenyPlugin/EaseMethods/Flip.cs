namespace TweenyPlugin
{
    public class Flip : AGetEase
    {
        public override float Get(float time)
        {
            return 1 - time;
        }
    }
}
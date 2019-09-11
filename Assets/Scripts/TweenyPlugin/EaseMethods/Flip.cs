namespace TweenyPlugin
{
    public class Flip : AEase
    {
        public override float Get(float time)
        {
            return 1 - time;
        }
    }
}
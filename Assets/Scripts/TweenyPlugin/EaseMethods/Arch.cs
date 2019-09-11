namespace TweenyPlugin
{
    public class Arch : AEase
    {
        public override float Get(float time)
        {
            return time * (1 - time);
        }
    }
}
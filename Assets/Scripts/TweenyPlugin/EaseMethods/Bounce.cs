namespace TweenyPlugin
{
    public class Bounce : AEase
    {
        public override float Get(float time)
        {
            if (time < 0f)
            {
                return -time;
            }

            if (time > 1f)
            {
                return 1f - (time - 1f);
            }

            return time;
        }
    }
}
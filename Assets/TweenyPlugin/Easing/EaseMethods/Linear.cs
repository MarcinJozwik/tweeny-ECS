using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class Linear : IEasing
    {
        public float Get(float time)
        {
            return time;
        }
    }
}
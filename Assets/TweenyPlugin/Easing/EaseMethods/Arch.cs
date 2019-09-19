using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class Arch : IEasing
    {
        public float Get(float time)
        {
            return new Scale(EaseMode.Flip).Get(time);
        }
    }
}
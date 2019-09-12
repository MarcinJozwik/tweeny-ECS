using EaseMethods;

namespace TweenyPlugin
{
    public class Arch : IEasing
    {
        public float Get(float time)
        {
            return new Scale(EaseMode.Flip).Get(time);
        }
    }
}
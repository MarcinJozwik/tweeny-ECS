using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class Flip : IEasing
    {
        private readonly Ease ease;

        public Flip(Ease ease)
        {
            this.ease = ease;
        }

        public float Get(float time)
        {
            return 1 - ease.Get(time);
        }
    }
}
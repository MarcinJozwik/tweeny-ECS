using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class Scale : IEasing
    {
        private readonly Ease ease;

        public Scale(Ease ease)
        {
            this.ease = ease;
        }

        public float Get(float time)
        {
            return ease.Get(time) * time;
        }

    }
}
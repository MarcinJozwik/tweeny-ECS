using TweenyPlugin;

namespace EaseMethods
{
    public class Scale : AEase
    {
        private readonly AEase ease;

        public Scale(AEase ease)
        {
            this.ease = ease;
        }

        public override float Get(float time)
        {
            return ease.Get(time) * time;
        }

    }
}
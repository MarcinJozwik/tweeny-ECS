using TweenyPlugin;

namespace EaseMethods
{
    public class Scale : AGetEase
    {
        private readonly AGetEase getEase;

        public Scale(Ease ease)
        {
            this.getEase = ease.EaseMethod;
        }
        
        public Scale(AGetEase getEase)
        {
            this.getEase = getEase;
        }

        public override float Get(float time)
        {
            return getEase.Get(time) * time;
        }

    }
}
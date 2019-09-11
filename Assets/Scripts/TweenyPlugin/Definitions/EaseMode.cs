namespace TweenyPlugin
{
    public static partial class EaseMode
    {
        public static readonly Ease SmoothStart2 = new Ease(new SmoothStart(2));
        public static readonly Ease SmoothStart3 = new Ease(new SmoothStart(3));
        public static readonly Ease SmoothStart4 = new Ease(new SmoothStart(4));
        public static readonly Ease SmoothStart5 = new Ease(new SmoothStart(5));
        
        public static readonly Ease SmoothStop2 = new Ease(new SmoothStop(SmoothStart2));
        public static readonly Ease SmoothStop3 = new Ease(new SmoothStop(SmoothStart3));
        public static readonly Ease SmoothStop4 = new Ease(new SmoothStop(SmoothStart4));
        public static readonly Ease SmoothStop5 = new Ease(new SmoothStop(SmoothStart5));
        
        public static readonly Ease Flip = new Ease(new Flip());
        
        public static readonly Ease Linear = new Ease(new Linear());
        
        public static readonly Ease Arch = new Ease(new Arch());
        
        public static readonly Ease SmoothStep2 = new Ease(new CrossFade(SmoothStart2.EaseMethod, SmoothStop2.EaseMethod));
        public static readonly Ease SmoothStep3 = new Ease(new CrossFade(SmoothStart3.EaseMethod, SmoothStop3.EaseMethod));
        public static readonly Ease SmoothStep4 = new Ease(new CrossFade(SmoothStart4.EaseMethod, SmoothStop4.EaseMethod));
        public static readonly Ease SmoothStep5 = new Ease(new CrossFade(SmoothStart5.EaseMethod, SmoothStop5.EaseMethod));
        
        
    }
}
using EaseMethods;
using TweenyPlugin.EaseMethods;

namespace TweenyPlugin
{
    public static partial class EaseMode
    {
        public static readonly Ease Linear = new Ease(new Linear());
        public static readonly Ease Flip = new Ease(new Flip());
        
        public static readonly Ease SmoothStart2 = new Ease(new SmoothStart(2));
        public static readonly Ease SmoothStart3 = new Ease(new SmoothStart(3));
        public static readonly Ease SmoothStart4 = new Ease(new SmoothStart(4));
        public static readonly Ease SmoothStart5 = new Ease(new SmoothStart(5));
        
        public static readonly Ease BlendSmoothStart5Linear = new Ease(new Blend(SmoothStart5, Linear, .5f));
        
        public static readonly Ease SmoothStop2 = new Ease(new SmoothStop(SmoothStart2));
        public static readonly Ease SmoothStop3 = new Ease(new SmoothStop(SmoothStart3));
        public static readonly Ease SmoothStop4 = new Ease(new SmoothStop(SmoothStart4));
        public static readonly Ease SmoothStop5 = new Ease(new SmoothStop(SmoothStart5));
        
        public static readonly Ease SmoothStep2 = new Ease(new CrossFade(SmoothStart2, SmoothStop2));
        public static readonly Ease SmoothStep3 = new Ease(new CrossFade(SmoothStart3, SmoothStop3));
        public static readonly Ease SmoothStep4 = new Ease(new CrossFade(SmoothStart4, SmoothStop4));
        public static readonly Ease SmoothStep5 = new Ease(new CrossFade(SmoothStart5, SmoothStop5));
        
        public static readonly Ease Arch2 = new Ease(new Arch());
        
        public static readonly Ease SmoothStartArch3 = new Ease(new Scale(Arch2));
        public static readonly Ease SmoothStopArch3 = new Ease(new ReverseScale(Arch2));
        
        public static readonly Ease Bell = new Ease(new Multiply(SmoothStartArch3,SmoothStopArch3));
        public static readonly Ease BellTwo = new Ease(new Pow(Bell, 2));
        public static readonly Ease BellThree = new Ease(new Pow(Bell, 3));
        
        public static readonly Ease Bell2 = new Ease(new Bell(2));
        public static readonly Ease Bell3 = new Ease(new Bell(3));
        public static readonly Ease Bell4 = new Ease(new Bell(4));
        public static readonly Ease Bell10 = new Ease(new Bell(10));
        
        public static readonly Ease Bezier = new Ease(new Bounce(new Bezier3(2f,-0.5f)));
        public static readonly Ease BouncedBezier7 = new Ease(new Bounce(new Bezier7(1f,1f,2,2,.5f,.5f)));
        
        
        
        
    }
}
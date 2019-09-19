using TweenyPlugin;
using TweenyPlugin.Easing.Definitions;

namespace Unity
{
    public static class TweenyExamples
    {
        public static Ease GetEase(int mode)
        {
            switch (mode)
            {
                case 0:
                    return EaseMode.BouncedBezier7;
                case 1:
                    return EaseMode.Bezier;
                case 2:
                    return EaseMode.SmoothStart4;
                case 3:
                    return EaseMode.SmoothStart3;
                case 4:
                    return EaseMode.SmoothStart2;
                case 5:
                    return EaseMode.Linear;
                case 6:
                    return EaseMode.SmoothStep2;
                case 7:
                    return EaseMode.SmoothStop2;
                case 8:
                    return EaseMode.SmoothStop3;
                case 9:
                    return EaseMode.SmoothStop4;
                default:
                    return EaseMode.Linear;
            }
        }
    }
}
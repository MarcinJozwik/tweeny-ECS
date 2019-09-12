using TweenyPlugin;

namespace Unity
{
    public static class TweenyTest
    {
        public static Ease GetEase(int mode)
        {
            switch (mode)
            {
                case 0:
                    return EaseMode.Linear;
                case 1:
                    return EaseMode.SmoothStart2;
                case 2:
                    return EaseMode.SmoothStart3;
                case 3:
                    return EaseMode.SmoothStart4;
                case 4:
                    return EaseMode.BouncedBezier7;
                case 5:
                    return EaseMode.SmoothStop2;
                case 6:
                    return EaseMode.SmoothStop3;
                case 7:
                    return EaseMode.SmoothStop4;
                case 8:
                    return EaseMode.SmoothStop5;
                case 9:
                    return EaseMode.SmoothStep2;
                case 10:
                    return EaseMode.Bezier;
                default:
                    return EaseMode.Linear;
            }
        }
    }
}
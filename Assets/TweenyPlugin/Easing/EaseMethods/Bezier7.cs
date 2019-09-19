using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class Bezier7 : IEasing
    {
        private readonly float b, c, d, e, f, g;

        public Bezier7(float b, float c, float d, float e, float f, float g)
        {
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
        }

        public float Get(float time)
        {
            float s = 1 - time;
            float t2 = time * time;
            float s2 = s * s;
            float t3 = t2 * time;
            float s3 = s2 * s;
            float t4 = t2 * t2;
            float s4 = s2 * s2;
            float t5 = t3 * t2;
            float s5 = s3 * s2;
            float t6 = t3 * t3;
            float s6 = s3 * s3;
            float t7 = t3 * t2 * t2;
            return (7f * b * s6 * time) + (21f * c * s5 * t2) + (35f * d * s4 * t3) +
                   (35f * e * s3 * t4) + (21f * f * s2 * t5) + (7f * g * s * t6) + (t7);
        }
    }
}
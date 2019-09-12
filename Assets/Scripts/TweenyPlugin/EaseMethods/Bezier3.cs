namespace TweenyPlugin.EaseMethods
{
    public class Bezier3 : IEasing
    {
        private float b;
        private float c;

        public Bezier3(float b, float c)
        {
            this.b = b;
            this.c = c;
        }

        public float Get(float time)
        {
            float s = 1 - time;
            float t2 = time * time;
            float s2 = s * s;
            float t3 = t2 * t2;
            return (3f * b * s2 * time) + (3f * c * s * t2) + (t3);
        }
    }
}
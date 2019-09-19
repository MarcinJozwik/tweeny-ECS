using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class SmoothStart : IEasing
    {
        private readonly uint power;

        public SmoothStart(uint power)
        {
            this.power = power;
        }

        public float Get(float time)
        {
            float value = time;
            
            for (int i = 1; i < power; i++)
            {
                value *= time;
            }

            return value;
        }
    }
}
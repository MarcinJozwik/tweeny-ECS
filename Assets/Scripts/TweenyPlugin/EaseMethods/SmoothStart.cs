using System;

namespace TweenyPlugin
{
    public class SmoothStart : AGetEase
    {
        private readonly uint power;

        public SmoothStart(uint power)
        {
            this.power = power;
        }

        public override float Get(float time)
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
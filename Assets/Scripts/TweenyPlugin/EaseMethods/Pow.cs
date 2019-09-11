using System;

namespace TweenyPlugin
{
    public class Pow : AEase
    {
        private readonly uint power;

        public Pow(uint power)
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
using System;

namespace TweenyPlugin
{
    public class Pow : IEasing
    {
        private readonly uint power;
        private readonly Ease ease;

        public Pow(Ease ease, uint power)
        {
            this.ease = ease;
            this.power = power;
        }
        
        public float Get(float time)
        {
            float baseValue = ease.Get(time);
            float value = baseValue;
            
            for (int i = 0; i < power; i++)
            {
                value *= baseValue;
            }

            return value;
        }
    }
}
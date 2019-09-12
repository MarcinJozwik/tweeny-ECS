using System;

namespace TweenyPlugin
{
    public class Pow : AGetEase
    {
        private readonly uint power;
        private readonly AGetEase getEase;

        public Pow(Ease ease, uint power)
        {
            this.getEase = ease.EaseMethod;
            this.power = power;
        }
        
        public Pow(AGetEase getEase, uint power)
        {
            this.getEase = getEase;
            this.power = power;
        }

        public override float Get(float time)
        {
            float baseValue = getEase.Get(time);
            float value = baseValue;
            
            for (int i = 0; i < power; i++)
            {
                value *= baseValue;
            }

            return value;
        }
    }
}
using UnityEngine;

namespace EaseMethods
{
    public class Pow : AGetValue
    {
        [Range(1, 10)] 
        public int Multiplier = 1;

        public AGetValue A;
        
        public override float GetValue(float time)
        {
            float value = 1f;
            float aValue = A.GetValue(time);

            for (int i = 0; i < Multiplier; i++)
            {
                value *= aValue;
            }

            return value;
        }
    }
}
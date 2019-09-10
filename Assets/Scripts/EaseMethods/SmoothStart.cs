using UnityEngine;

namespace EaseMethods
{
    public class SmoothStart : AGetValue
    {
        [Range(1,15)]
        public int Power = 2;
        
        public override float GetValue(float time)
        {
            float value = 1f;
            
            for (int i = 0; i < Power; i++)
            {
                value *= time;
            }

            return value;
        }
    }
}
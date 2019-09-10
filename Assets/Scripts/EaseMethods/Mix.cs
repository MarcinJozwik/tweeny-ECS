using UnityEngine;

namespace EaseMethods
{
    public class Mix : AGetValue
    {
        [Range(0f,1f)]
        public float Blend;

        public AGetValue A;
        public AGetValue B;
        
        public override float GetValue(float time)
        {
            return (A.GetValue(time) * (1 - Blend)) + (B.GetValue(time) * Blend);
        }
    }
}
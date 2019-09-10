namespace EaseMethods
{
    public class Bounce : AGetValue
    {
        public AGetValue A;
        
        public override float GetValue(float time)
        {
            float value = A.GetValue(time);
            
            if (value < 0f)
            {
                return -value;
            }

            if (value > 1f)
            {
                return 1f - (value - 1f);
            }

            return value;
        }
    }
}
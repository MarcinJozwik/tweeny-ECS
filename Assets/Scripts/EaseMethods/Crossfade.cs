namespace EaseMethods
{
    public class Crossfade : AGetValue
    {
        public AGetValue A;
        public AGetValue B;
        
        public override float GetValue(float time)
        {
            return (A.GetValue(time) * (1 - time)) + (B.GetValue(time) * time);
        }
    }
}
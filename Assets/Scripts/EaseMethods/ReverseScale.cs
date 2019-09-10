namespace EaseMethods
{
    public class ReverseScale : AGetValue
    {
        public AGetValue A;
        public override float GetValue(float time)
        {
            return A.GetValue(time) * (1 - time);
        }
    }
}
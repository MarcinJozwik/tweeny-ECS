namespace EaseMethods
{
    public class Multiply : AGetValue
    {
        public AGetValue A;
        public AGetValue B;
        public override float GetValue(float time)
        {
            return 4 * A.GetValue(time) * B.GetValue(time);
        }
    }
}
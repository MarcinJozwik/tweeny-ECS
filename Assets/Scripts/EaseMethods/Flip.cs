namespace EaseMethods
{
    public class Flip : AGetValue
    {
        public AGetValue A;
        
        public override float GetValue(float time)
        {
            return 1 - A.GetValue(time);
        }
    }
}
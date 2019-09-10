namespace EaseMethods
{
    public class Arch : AGetValue
    {
        public override float GetValue(float time)
        {
            return time * (1 - time);
        }
    }
}
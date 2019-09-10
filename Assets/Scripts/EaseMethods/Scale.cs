namespace EaseMethods
{
    public class Scale : AGetValue
    {
        public AGetValue A;
        public override float GetValue(float time)
        {
            return A.GetValue(time) * time;
        }
    }
}
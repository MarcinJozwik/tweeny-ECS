namespace EaseMethods
{
    public class SmoothEnd : AGetValue
    {
        public SmoothStart SmoothStart;
        public Flip Flip;
        public override float GetValue(float time)
        {
            float value = time;
            value = Flip.GetValue(value);
            value = SmoothStart.GetValue(value);
            value = Flip.GetValue(value);
            return value;
        }
    }
}
namespace TweenyPlugin.EaseMethods
{
    public class Bell : AGetEase
    {
        private readonly uint power;

        public Bell(uint power)
        {
            this.power = power;
        }

        public override float Get(float time)
        {
            return new Pow(EaseMode.Arch2, power).Get(time);
        }
    }
}
using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Easing.EaseMethods
{
    public class Bell : IEasing
    {
        private readonly uint power;

        public Bell(uint power)
        {
            this.power = power;
        }

        public float Get(float time)
        {
            return new Pow(EaseMode.Arch2, power).Get(time);
        }
    }
}
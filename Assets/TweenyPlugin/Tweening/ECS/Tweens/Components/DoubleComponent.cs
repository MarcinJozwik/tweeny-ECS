using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class DoubleComponent : IComponent
    {
        public double CurrentValue;
        public double StartValue;
        public double EndValue;
    }
}

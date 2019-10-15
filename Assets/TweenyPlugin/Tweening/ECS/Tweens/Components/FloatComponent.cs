using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class FloatComponent : IComponent
    {
        public float CurrentValue;
        public float StartValue;
        public float EndValue;
    }
}

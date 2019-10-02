using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Components
{
    [Tweeny]
    public class TimerComponent : IComponent
    {
        public float Current;
        public float Duration;
    }
}

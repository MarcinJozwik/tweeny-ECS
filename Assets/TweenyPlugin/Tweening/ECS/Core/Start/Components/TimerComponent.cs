using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Components
{
    [Tweeny]
    public class TimerComponent : IComponent
    {
        public float Current;
        public float Duration;
    }
}

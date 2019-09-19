using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Components
{
    [Tweeny]
    public class TimerComponent : IComponent
    {
        public float Timer;
        public float Duration;
    }
}

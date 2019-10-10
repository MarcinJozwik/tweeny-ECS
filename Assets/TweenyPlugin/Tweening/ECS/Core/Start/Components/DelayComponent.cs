using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Components
{
    [Tweeny]
    public class DelayComponent : IComponent
    {
        public float Delay;
        public float Timer;
    }
}

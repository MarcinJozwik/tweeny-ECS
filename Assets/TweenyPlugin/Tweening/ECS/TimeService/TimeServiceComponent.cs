using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace TweenyPlugin.Tweening.ECS.TimeService
{
    [Tweeny]
    [Unique]
    public class TimeServiceComponent : IComponent
    {
        public ITimeService Instance;
    }
}
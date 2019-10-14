using Entitas;
using TweenyPlugin.Utilities;

namespace TweenyPlugin.Tweening.ECS.Core.Finish.Components
{
    [Tweeny]
    public class LoopComponent : IComponent
    {
        public int Count;
        public int BaseAmount;
        public LoopType Type;
        public float DelayBetweenLoops;
    }
}

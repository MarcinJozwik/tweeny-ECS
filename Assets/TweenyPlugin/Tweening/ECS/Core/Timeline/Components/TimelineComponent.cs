using System.Collections.Generic;
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Components
{
    [Tweeny]
    public class TimelineComponent : IComponent
    {
        public int ActiveGroupIndex;
        public List<int[]> Groups;
    }
}

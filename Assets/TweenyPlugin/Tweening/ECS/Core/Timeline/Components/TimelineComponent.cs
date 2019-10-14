using System.Collections.Generic;
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Components
{
    [Tweeny]
    public class TimelineComponent : IComponent
    {
        public int Index;
        public int[] CurrentGroup;
        public List<int[]> Groups;
    }
}

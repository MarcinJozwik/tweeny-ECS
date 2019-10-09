using System.Collections.Generic;
using Entitas;

[Tweeny]
public class TimelineComponent : IComponent
{
    public int ActiveGroupIndex;
    public List<int[]> Groups;
}

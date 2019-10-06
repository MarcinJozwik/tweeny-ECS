using Entitas;
using TweenyPlugin.Tweening.ECS.Utilities;

[Tweeny]
public class LoopComponent : IComponent
{
    public int Count;
    public LoopType Type;
    public float DelayBetweenLoops;
}

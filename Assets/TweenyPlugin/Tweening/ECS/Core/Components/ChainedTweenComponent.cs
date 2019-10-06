using System;
using System.Collections.Generic;
using Entitas;

[Tweeny]
public class ChainedTweenComponent : IComponent
{
    public List<int> Ids = new List<int>();
    public Action OnChained;
}

using System;
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Components
{
    [Tweeny]
    public class StartActionComponent : IComponent
    {
        public Action OnStart;
    }
}

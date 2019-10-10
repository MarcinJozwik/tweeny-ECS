using System;
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Finish.Components
{
    [Tweeny]
    public class CompleteActionComponent : IComponent
    {
        public Action OnComplete;
    }
}

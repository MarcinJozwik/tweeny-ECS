using System;
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Finish.Components
{
    [Tweeny]
    public class CompleteLoopActionComponent : IComponent
    {
        public Action OnLoopComplete;
    }
}
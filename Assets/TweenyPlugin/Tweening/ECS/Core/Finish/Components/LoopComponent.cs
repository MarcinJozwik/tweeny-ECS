﻿using Entitas;
using TweenyPlugin.Tweening.ECS.Utilities;

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
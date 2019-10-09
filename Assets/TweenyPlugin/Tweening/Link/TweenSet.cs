using System;
using TweenyPlugin.Tweening.ECS.Utilities;

namespace TweenyPlugin.Tweening.Link
{
    public class TweenSet : ITweenSet<TweenSet>
    {
        public bool IsReversed;
        public bool IsMirrored;
        public int Loops;
        public LoopType LoopType;
        public float DelayBetweenLoops;
        public float InitialDelay;
        public Action OnStartAction;
        public Action OnLoopCompleteAction;
        public Action OnCompleteAction;

        public TweenSet()
        {
            IsReversed = false;
            IsMirrored = false;
            Loops = 0;
            LoopType = LoopType.Restart;
            DelayBetweenLoops = 0f;
            InitialDelay = 0f;
            OnStartAction = null;
            OnLoopCompleteAction = null;
            OnCompleteAction = null;
        }

        public TweenSet Reverse()
        {
            IsReversed = true;
            return this;
        }

        public TweenSet Mirror()
        {
            IsMirrored = true;
            return this;
        }

        public TweenSet SetLoops(int loops, LoopType type = LoopType.Restart, float delayBetweenLoops = 0)
        {
            Loops = loops;
            LoopType = type;
            DelayBetweenLoops = delayBetweenLoops;
            return this;
        }

        public TweenSet SetDelay(float delay)
        {
            InitialDelay = delay;
            return this;
        }

        public TweenSet OnStart(Action action)
        {
            OnStartAction = action;
            return this;
        }

        public TweenSet OnLoopComplete(Action action)
        {
            OnLoopCompleteAction = action;
            return this;
        }

        public TweenSet OnComplete(Action action)
        {
            OnCompleteAction = action;
            return this;
        }
    }
}
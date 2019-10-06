using System;
using TweenyPlugin.Tweening.ECS.Utilities;

namespace TweenyPlugin.Tweening.Link
{
    public class Tween
    {
        private readonly TweenyContext context;
        private readonly int id;
        
        public Tween(int id)
        {
            this.context = Contexts.sharedInstance.tweeny;
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void Play()
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isPlayMessage = true;
            message.isMessage = true;
        }
        
        public void Stop()
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isStopMessage = true;
            message.isMessage = true;
        }

        public Tween OnComplete(Action action)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddCompleteAction(action);
            message.isMessage = true;
            return this;
        }
        
        public Tween OnLoopComplete(Action action)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddCompleteLoopAction(action);
            message.isMessage = true;
            return this;
        }

        public Tween SetLoops(int loops, LoopType type = LoopType.Restart, float delayBetweenLoops = 0f)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddLoop(loops, type, delayBetweenLoops);
            message.isMessage = true;
            return this;
        }
        
        public Tween Reverse()
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isReverse = true;
            message.isMessage = true;
            return this;
        }
        
        public Tween Mirror()
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isMirror = true;
            message.isMessage = true;
            return this;
        }

        public Tween SetDelay(float delay)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddDelay(delay, 0f);
            message.isMessage = true;
            return this;
        }

        public void Next(Tween tween)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddChainedTween(tween.GetId());
            message.isMessage = true;
        }
    }
}
using System;
using System.Collections.Generic;
using TweenyPlugin.Tweening.ECS.Utilities;

namespace TweenyPlugin.Tweening.Link
{
    public class Tween
    {
        private readonly TweenyContext context;
        private readonly int id;
        
        private float duration = 0f;
        private float initialDelay = 0f;
        private float delayBetweenLoops = 0f;
        private int loops = 1;
        
        public Tween(int id, float duration)
        {
            this.context = Contexts.sharedInstance.tweeny;
            this.id = id;
            this.duration = duration;
        }

        public int GetId()
        {
            return id;
        }

        public float GetTotalDuration()
        {
            return initialDelay + (duration * loops) + (delayBetweenLoops * (loops - 1));
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
        
        public Tween OnStart(Action action)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddStartAction(action);
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
            this.loops = loops;
            this.delayBetweenLoops = delayBetweenLoops;
            
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
            this.initialDelay = delay;
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddDelay(delay, 0f);
            message.isMessage = true;
            return this;
        }

        public void Next(Tween[] tweens)
        {
            List<int> ids = new List<int>();

            for (var i = 0; i < tweens.Length; i++)
            {
                var tween = tweens[i];
                ids.Add(tween.GetId());
            }

            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddChainedTween(ids);
            message.isMessage = true;
        }
    }
}
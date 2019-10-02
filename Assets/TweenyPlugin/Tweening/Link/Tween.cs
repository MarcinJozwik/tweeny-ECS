using System;
using TweenyPlugin.Tweening.ECS.Utilities;

namespace TweenyPlugin.Tweening.Link
{
    public class Tween
    {
        private TweenyContext context;
        private int id;
        
        public Tween(int id)
        {
            this.context = Contexts.sharedInstance.tweeny;
            this.id = id;
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

        public Tween SetLoops(int loops, LoopType type = LoopType.Restart)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddLoop(loops, type);
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

        public void Destroy()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                entity.Destroy();
            }
        }
    }
}
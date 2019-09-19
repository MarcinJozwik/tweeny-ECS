using System;

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
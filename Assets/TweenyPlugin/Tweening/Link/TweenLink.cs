using System;

namespace TweenyPlugin.Tweening.Link
{
    public class TweenLink
    {
        private TweenyContext context;
        private int id;
        
        public TweenLink(int id)
        {
            this.context = Contexts.sharedInstance.tweeny;
            this.id = id;
        }

        public void Play()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                entity.isTweening = true;
            }
        }
        
        public void Stop()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                entity.isTweening = false;
            }
        }

        public TweenLink OnComplete(Action action)
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                if (!entity.hasCompleteAction)
                {
                    entity.AddCompleteAction(action);
                }
            }

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
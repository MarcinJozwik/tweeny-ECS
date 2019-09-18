using Entitas;

namespace TweenyPlugin.TweenSystems
{
    public class TweenLink
    {
        private TweenyEntity entity;

        public TweenLink(TweenyEntity entity)
        {
            this.entity = entity;
        }

        public void Play()
        {
            entity.isTweening = true;
        }
        
        public void Stop()
        {
            entity.isTweening = false;
        }

        public void Destroy()
        {
            entity.Destroy();
        }
    }
}
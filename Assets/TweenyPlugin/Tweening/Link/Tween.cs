namespace TweenyPlugin.Tweening.Link
{
    public class Tween : ITweenable
    {
        private readonly TweenyContext context;
        private readonly int id;
        private readonly float duration = 0f;

        private bool playing = false;

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
            return duration;
        }

        public bool IsFinished()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                return entity.isFinished;
            }

            return true;
        }

        public bool IsPlaying()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                return entity.isTweening && !IsFinished();
            }

            return false;
        }

        public void Play()
        {
            if (IsFinished())
            {
                return;
            }
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isPlayMessage = true;
            message.isMessage = true;

            playing = true;
        }
        
        public void Stop()
        {
            if (IsFinished())
            {
                return;
            }
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isStopMessage = true;
            message.isMessage = true;

            playing = false;
        }

        public void GoTo(float step)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddGoToMessage(step);
            message.isMessage = true;
        }

        public void Reset()
        {
            if (IsFinished())
            {
                return;
            }
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isResetMessage = true;
            message.isMessage = true;
        }
    }
}
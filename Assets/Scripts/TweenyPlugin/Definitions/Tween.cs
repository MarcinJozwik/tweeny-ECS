using UnityEngine;

namespace TweenyPlugin
{
    public abstract class Tween
    {
        public bool Finished = false;
        
        protected readonly float Duration;
        protected float Timer = 0f;

        protected Tween(float duration)
        {
            this.Duration = duration;
        }

        public virtual void Update(float deltaTime)
        {
            OnComplete();
            TickTimer(deltaTime);
        }

        protected virtual void TickTimer(float step)
        {
            Timer = Mathf.MoveTowards(Timer, Duration, step);
        }
        
        protected virtual void OnComplete()
        {
            if (Timer >= Duration)
            {
                Finished = true;
                TweenyCollector.Unregister(this);
            }
        }
    }
}
using UnityEngine;

namespace TweenyPlugin
{
    public abstract class Tween
    {
        public bool Finished = false;

        protected float EaseValue = 0f;
        
        private readonly float duration;
        private readonly Ease ease;

        private float timer = 0f;
        
        protected Tween(float duration, Ease ease)
        {
            this.duration = duration;
            this.ease = ease;
        }

        public virtual void Update(float deltaTime)
        {
            OnComplete();
            
            timer = Mathf.MoveTowards(timer, duration, deltaTime);
            EaseValue = Tweeny.GetValue(timer, 0, duration, ease);
        }

        protected virtual void OnComplete()
        {
            if (timer >= duration)
            {
                Finished = true;
                TweenyCollector.Unregister(this);
            }
        }
    }
}
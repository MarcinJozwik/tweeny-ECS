using UnityEngine;

namespace TweenyPlugin
{
    public class TScale : Tween
    {
        private readonly Transform transform;
        
        private readonly Vector3 startScale;
        private readonly Vector3 endScale;
        private readonly Vector3 distance;

        public TScale(Transform transform, Vector3 startScale, Vector3 endScale, float duration, Ease ease) : base(duration, ease)
        {
            this.transform = transform;
            this.startScale = startScale;
            this.endScale = endScale;
            this.distance = endScale - startScale;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            transform.localScale = startScale + (distance * EaseValue);
        }
    }
}
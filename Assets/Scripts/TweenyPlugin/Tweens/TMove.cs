using UnityEngine;

namespace TweenyPlugin
{
    public class TMove : Tween
    {
        private readonly Transform transform;
        private readonly Ease ease;
        
        private readonly Vector3 startPosition;
        private readonly Vector3 direction;
        private readonly float distance;

        private float easeValue = 0f;

        public TMove(Transform transform, Vector3 startPosition, Vector3 endPosition, float duration, Ease ease) : base(duration)
        {
            this.transform = transform;
            this.ease = ease;
            
            this.startPosition = startPosition;
            this.direction = (endPosition - startPosition).normalized;
            this.distance = Vector3.Distance(endPosition, startPosition);
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            easeValue = Tweeny.GetValue(Timer, 0, Duration, ease);
            transform.position = startPosition + (easeValue * distance * direction);
        }
    }
}
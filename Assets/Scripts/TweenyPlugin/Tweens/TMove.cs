using UnityEngine;

namespace TweenyPlugin
{
    public class TMove : Tween
    {
        private readonly Transform transform;
        
        private readonly Vector3 startPosition;
        private readonly Vector3 direction;
        private readonly float distance;
        
        public TMove(Transform transform, Vector3 startPosition, Vector3 endPosition, float duration, Ease ease) : base(duration, ease)
        {
            this.transform = transform;
            
            this.startPosition = startPosition;
            this.direction = (endPosition - startPosition).normalized;
            this.distance = Vector3.Distance(endPosition, startPosition);
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            
            transform.position = startPosition + (EaseValue * distance * direction);
        }
    }
}
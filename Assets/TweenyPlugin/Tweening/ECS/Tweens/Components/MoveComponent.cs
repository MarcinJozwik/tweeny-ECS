using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class MoveComponent : IComponent
    {
        public Vector3 StartPosition;
        public Vector3 Direction;
        public float Distance;
    }
}

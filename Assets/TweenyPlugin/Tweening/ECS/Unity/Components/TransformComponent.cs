using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Unity.Components
{
    [Tweeny]
    public class TransformComponent : IComponent
    {
        public Transform Transform;
    }
}

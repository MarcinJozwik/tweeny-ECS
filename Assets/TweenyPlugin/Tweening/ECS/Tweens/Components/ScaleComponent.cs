using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class ScaleComponent : IComponent
    {
        public Vector3 StartScale;
        public Vector3 Distance;
    }
}
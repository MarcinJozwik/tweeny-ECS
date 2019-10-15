using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class Vector3Component : IComponent
    {
        public Vector3 CurrentValue;
        public Vector3 StartValue;
        public Vector3 EndValue;
    }
}

using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class Vector2Component : IComponent
    {
        public Vector2 CurrentValue;
        public Vector2 StartValue;
        public Vector2 EndValue;
    }
}

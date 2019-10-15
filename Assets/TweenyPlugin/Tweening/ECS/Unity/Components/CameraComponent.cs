using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Unity.Components
{
    [Tweeny]
    public class CameraComponent : IComponent
    {
        public Camera Camera;
    }
}

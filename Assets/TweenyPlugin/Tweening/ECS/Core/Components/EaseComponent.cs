using Entitas;
using TweenyPlugin.Easing.Definitions;

namespace TweenyPlugin.Tweening.ECS.Core.Components
{
    [Tweeny]
    public class EaseComponent : IComponent
    {
        public Ease Type;
        public float Value;
    }
}

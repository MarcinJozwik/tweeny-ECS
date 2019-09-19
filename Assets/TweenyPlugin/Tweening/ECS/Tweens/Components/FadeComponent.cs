using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Components
{
    [Tweeny]
    public class FadeComponent : IComponent
    {
        public float StartAlpha;
        public float EndAlpha;
    }
}

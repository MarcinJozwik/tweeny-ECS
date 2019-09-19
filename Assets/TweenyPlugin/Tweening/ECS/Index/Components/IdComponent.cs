using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace TweenyPlugin.Tweening.ECS.Index.Components
{
    [Tweeny, Input]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int Value;
    }
}
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace TweenyPlugin.TweenSystems.Index.Components
{
    [Tweeny, Input]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int Value;
    }
}
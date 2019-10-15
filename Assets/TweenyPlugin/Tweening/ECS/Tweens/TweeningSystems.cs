using TweenyPlugin.Tweening.ECS.Tweens.Systems;

namespace TweenyPlugin.Tweening.ECS.Tweens
{
    public class TweeningSystems : Feature
    {
        public TweeningSystems(Contexts contexts)
            : base("Tweening Systems")
        {
            this.Add(new TweenFloatSystem(contexts));
            this.Add(new TweenDoubleSystem(contexts));
            this.Add(new TweenVector2System(contexts));
            this.Add(new TweenVector3System(contexts));
            this.Add(new TweenColorSystem(contexts));
            this.Add(new TweenQuaternionSystem(contexts));
        }
    }
}
using TweenyPlugin.Tweening.ECS.Core.Finish.Systems;
using TweenyPlugin.Tweening.ECS.Tweens.Systems;

namespace TweenyPlugin.Tweening.ECS.Tweens
{
    public class TweeningSystems : Feature
    {
        public TweeningSystems(Contexts contexts)
            : base("Tweening Systems")
        {
            this.Add(new MoveSystem(contexts));
            this.Add(new ScaleSystem(contexts));
            this.Add(new FadeSystem(contexts));
            this.Add(new CountTimeSystem(contexts));
        }
    }
}
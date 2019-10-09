using TweenyPlugin.Tweening.ECS.Core;
using TweenyPlugin.Tweening.ECS.Messages;
using TweenyPlugin.Tweening.ECS.Tweens;

namespace TweenyPlugin.Tweening.ECS
{
    public class TweenySystems : Feature
    {
        public TweenySystems(Contexts contexts) : base("Tweeny Systems")
        {
            this.Add(new MessageSystems(contexts));
            this.Add(new CoreSystems(contexts));
            this.Add(new TweeningSystems(contexts));
        }
    }
}
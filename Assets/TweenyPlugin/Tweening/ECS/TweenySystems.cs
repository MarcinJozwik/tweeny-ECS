using TweenyPlugin.Tweening.ECS.Core.Finish;
using TweenyPlugin.Tweening.ECS.Core.Start;
using TweenyPlugin.Tweening.ECS.Core.Timeline;
using TweenyPlugin.Tweening.ECS.Messages;
using TweenyPlugin.Tweening.ECS.Tweens;

namespace TweenyPlugin.Tweening.ECS
{
    public class TweenySystems : Feature
    {
        public TweenySystems(Contexts contexts) : base("Tweeny Systems")
        {
            this.Add(new MessageSystems(contexts));
            this.Add(new OpeningSystems(contexts));
            this.Add(new TweeningSystems(contexts));
            this.Add(new ClosingSystems(contexts));
            this.Add(new TimelineSystems(contexts));
        }
    }
}
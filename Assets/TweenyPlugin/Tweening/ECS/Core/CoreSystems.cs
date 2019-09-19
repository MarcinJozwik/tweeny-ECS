using TweenyPlugin.Tweening.ECS.Core.Systems;

namespace TweenyPlugin.Tweening.ECS.Core
{
    public class CoreSystems : Feature
    {
        public CoreSystems(Contexts contexts)
            : base("Core Systems")
        {
            this.Add(new CountTimeSystem(contexts));
            this.Add(new DoCompleteActionSystem(contexts));
            this.Add(new FinishTweenSystem(contexts));
            this.Add(new TickTimerSystem(contexts));
            this.Add(new GetEaseSystem(contexts));
        }
    }
}
using TweenyPlugin.Tweening.ECS.Core.Systems;

namespace TweenyPlugin.Tweening.ECS.Core
{
    public class CoreSystems : Feature
    {
        public CoreSystems(Contexts contexts) : base("Core Systems")
        {
            this.Add(new CountTimeSystem(contexts));
            this.Add(new DoCompleteLoopActionSystem(contexts));
            this.Add(new SetLoopSystem(contexts));
            this.Add(new DoCompleteActionSystem(contexts));
            this.Add(new ActivateChainedTweenSystem(contexts));
            this.Add(new FinishTweenSystem(contexts));
            this.Add(new TickTimerSystem(contexts));
            this.Add(new GetProgressSystem(contexts));
            this.Add(new ReverseProgressSystem(contexts));
            this.Add(new GetEaseSystem(contexts));
            this.Add(new MirrorEaseSystem(contexts));
        }
    }
}
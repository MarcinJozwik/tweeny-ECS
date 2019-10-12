using TweenyPlugin.Tweening.ECS.Core.Finish.Systems;

namespace TweenyPlugin.Tweening.ECS.Core.Finish
{
    public class ClosingSystems : Feature
    {
        public ClosingSystems(Contexts contexts) : base("Closing Systems")
        {
            this.Add(new CountTimeSystem(contexts));
            this.Add(new DoCompleteLoopActionSystem(contexts));
            this.Add(new SetLoopSystem(contexts));
            this.Add(new DoCompleteActionSystem(contexts));
            this.Add(new FinishTweenSystem(contexts));
        }
    }
}
using TweenyPlugin.Tweening.ECS.Core.Start.Systems;

namespace TweenyPlugin.Tweening.ECS.Core.Start
{
    public class OpeningSystems : Feature
    {
        public OpeningSystems(Contexts contexts) : base("Opening Systems")
        {
            this.Add(new HandleDelaySystem(contexts));
            this.Add(new HandleBetweenLoopDelaySystem(contexts));
            this.Add(new DoStartActionSystem(contexts));
            this.Add(new StartTimelineSystem(contexts));
            this.Add(new StartTweenSystem(contexts));
            this.Add(new TickTimerSystem(contexts));
            this.Add(new GetProgressSystem(contexts));
            this.Add(new ReverseProgressSystem(contexts));
            this.Add(new GetEaseSystem(contexts));
            this.Add(new MirrorEaseSystem(contexts));
        }
    }
}
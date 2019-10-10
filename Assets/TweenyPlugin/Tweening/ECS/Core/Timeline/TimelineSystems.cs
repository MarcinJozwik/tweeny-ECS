using TweenyPlugin.Tweening.ECS.Core.Timeline.Systems;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline
{
    public class TimelineSystems : Feature
    {
        public TimelineSystems(Contexts contexts) : base("Timeline Systems")
        {
            this.Add(new DetectGroupFinishSystem(contexts));
            this.Add(new ChangeGroupIndexSystem(contexts));
            this.Add(new PlayNextGroupSystem(contexts));
        }
    }
}
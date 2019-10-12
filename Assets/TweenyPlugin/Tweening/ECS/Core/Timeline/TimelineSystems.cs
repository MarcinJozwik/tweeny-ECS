using TweenyPlugin.Tweening.ECS.Core.Timeline.Systems;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline
{
    public class TimelineSystems : Feature
    {
        public TimelineSystems(Contexts contexts) : base("Timeline Systems")
        {
            this.Add(new DetectGroupFinishSystem(contexts));
            this.Add(new ChangeGroupIndexSystem(contexts));
            this.Add(new DetectTimelineFinish(contexts));
            this.Add(new PlayGroupSystem(contexts));
            this.Add(new StopGroupSystem(contexts));
            this.Add(new ResetGroupSystem(contexts));
        }
    }
}
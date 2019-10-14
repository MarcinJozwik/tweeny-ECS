using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Systems
{
    public class InvertCurrentGroupSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> timelineGroup;

        public InvertCurrentGroupSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.timelineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher
                .AllOf(TweenyMatcher.Timeline, TweenyMatcher.Tweening)
                .AnyOf(TweenyMatcher.Reverse, TweenyMatcher.Mirror)
                .NoneOf(TweenyMatcher.Finishing));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.timelineGroup.GetEntities();
            int count = entities.Length;
		
            for (int i = 0; i < count; i++)
            {
                var timeline = entities[i].timeline;
                timeline.CurrentGroup = timeline.Groups[timeline.Groups.Count - 1 - timeline.Index];
            }
        }
    }
}
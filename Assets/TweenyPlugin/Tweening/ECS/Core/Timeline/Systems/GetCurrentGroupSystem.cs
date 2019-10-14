using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Systems
{
    public class GetCurrentGroupSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> timelineGroup;

        public GetCurrentGroupSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.timelineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher
                .AllOf(TweenyMatcher.Timeline, TweenyMatcher.Tweening, TweenyMatcher.GroupFinish));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.timelineGroup.GetEntities();
            int count = entities.Length;
		
            for (int i = 0; i < count; i++)
            {
                var entity = entities[i];
                var timeline = entity.timeline;
                
                timeline.CurrentGroup = entity.isFinishing ? null : timeline.Groups[timeline.Index];
            }
        }
    }
}
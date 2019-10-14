using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Systems
{
	public class DetectTimelineFinish : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> timelineGroup;

		public DetectTimelineFinish(Contexts contexts) 
		{
			this.contexts = contexts;
			this.timelineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Timeline, TweenyMatcher.Tweening, TweenyMatcher.GroupFinish));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.timelineGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
			
				if (entity.timeline.Index >= entity.timeline.Groups.Count)
				{
					entity.isFinishing = true;
				}
				else
				{
					entity.isPlayMessage = true;
				}
			}
		}
	}
}
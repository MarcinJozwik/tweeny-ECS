using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Systems
{
	public class ResetGroupSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> timelineGroup;

		public ResetGroupSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.timelineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Timeline, TweenyMatcher.ResetGroup, TweenyMatcher.Tweening));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.timelineGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
						
				int[] group = entity.timeline.CurrentGroup;
			
				if (group != null)
				{
					for (var j = 0; j < @group.Length; j++)
					{
						TweenyEntity tweenEntity = this.contexts.tweeny.GetEntityWithId(@group[j]);
						tweenEntity.isResetMessage = true;
					}

					entity.isResetGroup = false;
				}
			}
		}
	}
}
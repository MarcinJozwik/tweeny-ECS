using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Timeline.Systems
{
	public class DetectGroupFinishSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> timelineGroup;

		public DetectGroupFinishSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.timelineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Timeline, TweenyMatcher.Tweening));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.timelineGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				int[] group = entity.timeline.CurrentGroup;
			
				if (group == null)
				{
					continue;
				}
				
				bool allFinished = true;
			
				for (var j = 0; j < group.Length; j++)
				{
					TweenyEntity tweenEntity = this.contexts.tweeny.GetEntityWithId(group[j]);
				
					//if any entity still exist it means that some tween from group is still playing
					if (!tweenEntity.isFinished)
					{
						allFinished = false;
					}
				}

				if (allFinished)
				{
					entity.isGroupFinish = true;
				}
			}
		}
	}
}
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
	// Ensure timeline playing when it's starts with initial delay
	public class StartTimelineSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> startingGroup;

		public StartTimelineSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.startingGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Timeline, TweenyMatcher.Starting, TweenyMatcher.Tweening));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.startingGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.isPlayMessage = true;
			}
		}
	}
}
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
	public class StartTweenSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> startingGroup;

		public StartTweenSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.startingGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Starting, TweenyMatcher.Tweening));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.startingGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.isStarting = false;
				entity.isStarted = true;
			}
		}
	}
}
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
	public class DoCompleteActionSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> completeActionGroup;

		public DoCompleteActionSystem(Contexts contexts)
		{
			this.contexts = contexts;
			this.completeActionGroup = this.contexts.tweeny.GetGroup(
				TweenyMatcher.AllOf(TweenyMatcher.CompleteAction, TweenyMatcher.Tweening,
					TweenyMatcher.Finish));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.completeActionGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.completeAction.OnComplete();
			}
		}
	}
}
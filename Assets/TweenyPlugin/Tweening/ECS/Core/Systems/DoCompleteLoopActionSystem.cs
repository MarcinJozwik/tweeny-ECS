using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
	public class DoCompleteLoopActionSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> completeActionGroup;

		public DoCompleteLoopActionSystem(Contexts contexts)
		{
			this.contexts = contexts;
			this.completeActionGroup = this.contexts.tweeny.GetGroup(
				TweenyMatcher.AllOf(TweenyMatcher.CompleteLoopAction, TweenyMatcher.Tweening,
					TweenyMatcher.Loop, TweenyMatcher.Finishing));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.completeActionGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				if (entity.loop.Count > 0 || entity.loop.Count == -1)
				{
					entity.completeLoopAction.OnLoopComplete();
				}
			}
		}
	}
}
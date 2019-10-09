using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
	public class FinishTweenSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> finishGroup;

		public FinishTweenSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.finishGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Finishing, TweenyMatcher.Tweening));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.finishGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.isFinishing = false;
				entity.isFinished = true;
				entity.isTweening = false;
			}
		}
	}
}
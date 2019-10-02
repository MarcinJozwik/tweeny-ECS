using Entitas;
using TweenyPlugin.Core;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
	public class GetEaseSystem : IExecuteSystem
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> easeGroup;

		public GetEaseSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.easeGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Ease, TweenyMatcher.Progress));
		}
    
		public void Execute()
		{
			TweenyEntity[] entities = this.easeGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.ease.Value = Tweeny.GetValue(entity.progress.Value, 0, 1, entity.ease.Type);
			}
		}
	}
}
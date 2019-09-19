using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Systems
{
	public class ScaleSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> scaleGroup;

		public ScaleSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.scaleGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Scale, TweenyMatcher.Transform, TweenyMatcher.Ease));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.scaleGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.transform.Transform.localScale = entity.scale.StartScale + (entity.scale.Distance * entity.ease.Value);
			}
		}
	}
}
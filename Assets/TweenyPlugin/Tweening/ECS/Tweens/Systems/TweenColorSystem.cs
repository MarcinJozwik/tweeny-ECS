using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Systems
{
	public class TweenColorSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> floatGroup;

		public TweenColorSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.floatGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Color, TweenyMatcher.Ease));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.floatGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.color.CurrentValue = entity.color.StartValue + entity.ease.Value * (entity.color.EndValue - entity.color.StartValue);
			}
		}
	}
}
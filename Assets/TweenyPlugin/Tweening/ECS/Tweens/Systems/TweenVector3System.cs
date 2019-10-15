using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Systems
{
	public class TweenVector3System : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> vector3Group;

		public TweenVector3System(Contexts contexts) 
		{
			this.contexts = contexts;
			this.vector3Group = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Vector3, TweenyMatcher.Ease));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.vector3Group.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.vector3.CurrentValue = entity.vector3.StartValue + entity.ease.Value * (entity.vector3.EndValue - entity.vector3.StartValue);
			}
		}
	}
}
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncTransformScaleSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> scaleGroup;

		public SyncTransformScaleSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.scaleGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Scale, TweenyMatcher.Transform, TweenyMatcher.Vector3));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.scaleGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.transform.Transform.localScale = entity.vector3.CurrentValue;
			}
		}
	}
}
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncLightRangeSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> lightGroup;

		public SyncLightRangeSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.lightGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Light,
				TweenyMatcher.Range, TweenyMatcher.Float));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.lightGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.light.Light.range = entity.@float.CurrentValue;
			}
		}
	}
}
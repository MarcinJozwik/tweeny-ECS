using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncTweenyColorSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> tweenyColorGroup;

		public SyncTweenyColorSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.tweenyColorGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.TweenyColor, TweenyMatcher.Color));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.tweenyColorGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.tweenyColor.TweenyColor.Value = entity.color.CurrentValue;
			}
		}
	}
}
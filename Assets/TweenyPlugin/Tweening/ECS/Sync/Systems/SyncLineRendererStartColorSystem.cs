using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncLineRendererStartColorSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> lineGroup;

		public SyncLineRendererStartColorSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.lineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.LineRenderer,
				TweenyMatcher.Color, TweenyMatcher.StartParameter));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.lineGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.lineRenderer.LineRenderer.startColor = entity.color.CurrentValue;
			}
		}
	}
}
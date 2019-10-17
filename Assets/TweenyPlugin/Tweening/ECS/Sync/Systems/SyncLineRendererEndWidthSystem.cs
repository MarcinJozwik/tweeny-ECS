using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncLineRendererEndWidthSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> lineGroup;

		public SyncLineRendererEndWidthSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.lineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.LineRenderer,
				TweenyMatcher.Width, TweenyMatcher.Float, TweenyMatcher.EndParameter));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.lineGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.lineRenderer.LineRenderer.endWidth = entity.@float.CurrentValue;
			}
		}
	}
}
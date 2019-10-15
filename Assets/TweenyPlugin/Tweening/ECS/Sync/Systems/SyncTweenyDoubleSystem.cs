using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncTweenyDoubleSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> tweenyDoubleGroup;

		public SyncTweenyDoubleSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.tweenyDoubleGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.TweenyDouble, TweenyMatcher.Double));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.tweenyDoubleGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.tweenyDouble.TweenyDouble.Value = entity.@double.CurrentValue;
			}
		}
	}
}
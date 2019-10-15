using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncTweenyFloatSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> tweenyFloatGroup;

		public SyncTweenyFloatSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.tweenyFloatGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.TweenyFloat, TweenyMatcher.Float));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.tweenyFloatGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.tweenyFloat.TweenyFloat.Value = entity.@float.CurrentValue;
			}
		}
	}
}
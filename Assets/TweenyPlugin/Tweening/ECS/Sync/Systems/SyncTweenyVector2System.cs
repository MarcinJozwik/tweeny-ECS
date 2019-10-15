using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncTweenyVector2System : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> tweenyVector2Group;

		public SyncTweenyVector2System(Contexts contexts) 
		{
			this.contexts = contexts;
			this.tweenyVector2Group = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.TweenyVector2, TweenyMatcher.Vector2));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.tweenyVector2Group.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.tweenyVector2.TweenyVector2.Value = entity.vector2.CurrentValue;
			}
		}
	}
}
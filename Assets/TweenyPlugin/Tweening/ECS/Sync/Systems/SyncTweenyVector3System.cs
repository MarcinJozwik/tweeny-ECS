using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncTweenyVector3System : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> tweenyVector3Group;

		public SyncTweenyVector3System(Contexts contexts) 
		{
			this.contexts = contexts;
			this.tweenyVector3Group = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.TweenyVector3, TweenyMatcher.Vector3));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.tweenyVector3Group.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.tweenyVector3.TweenyVector3.Value = entity.vector3.CurrentValue;
			}
		}
	}
}
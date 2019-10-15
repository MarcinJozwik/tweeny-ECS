using Entitas;

namespace TweenyPlugin.Tweening.ECS.Messages.Systems
{
	public class CleanupPlaySystem : ICleanupSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> playGroup;

		public CleanupPlaySystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.playGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.PlayMessage).NoneOf(TweenyMatcher.DelayedMessage));
		}

		public void Cleanup()
		{
			TweenyEntity[] entities = this.playGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.isPlayMessage = false;
			}
		}
	}
}
using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
	public class MirrorEaseSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> mirrorGroup;

		public MirrorEaseSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.mirrorGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Ease, TweenyMatcher.Mirror));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.mirrorGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.ease.Value = 1 - entity.ease.Value;
			}
		}
	}
}
using Entitas;
using TweenyPlugin.Core;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
	public class GetEaseSystem : IExecuteSystem
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> easeGroup;

		public GetEaseSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.easeGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Ease, TweenyMatcher.Timer));
		}
    
		public void Execute()
		{
			TweenyEntity[] entities = this.easeGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.ease.Value = Tweeny.GetValue(entity.timer.Timer, 0, entity.timer.Duration, entity.ease.Type);
			}
		}

//	public GetEaseSystem(TweenyContext context, int threads) : base(
//		context.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Ease,
//			TweenyMatcher.Timer)), threads)
//	{
//	}
//
//    protected override void Execute(TweenyEntity entity)
//    {
//	    entity.ease.Value = Tweeny.GetValue(entity.timer.Timer, 0, entity.timer.Duration, entity.ease.Type);
//    }

	}
}
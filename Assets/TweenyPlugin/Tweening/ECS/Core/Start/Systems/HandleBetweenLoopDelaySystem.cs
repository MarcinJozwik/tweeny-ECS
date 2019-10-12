using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
	public class HandleBetweenLoopDelaySystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> delayGroup;

		public HandleBetweenLoopDelaySystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.delayGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Loop, TweenyMatcher.BetweenLoops));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.delayGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.betweenLoops.Timer = Mathf.MoveTowards(entity.betweenLoops.Timer, entity.loop.DelayBetweenLoops, contexts.tweeny.timeService.Instance.GetDeltaTime());

				if (entity.betweenLoops.Timer >= entity.loop.DelayBetweenLoops)
				{
					entity.isTweening = true;
					entity.RemoveBetweenLoops();
				}
				else
				{
					entity.isTweening = false;
				}
			}
		}
	}
}
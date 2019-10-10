using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
	public class HandleDelaySystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> delayGroup;

		public HandleDelaySystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.delayGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Delay, TweenyMatcher.Starting));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.delayGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.delay.Timer = Mathf.MoveTowards(entity.delay.Timer, entity.delay.Delay, Time.deltaTime);

				if (entity.delay.Timer >= entity.delay.Delay)
				{
					entity.isTweening = true;
					entity.RemoveDelay();
				}
				else
				{
					entity.isTweening = false;
				}
			}
		}
	}
}
﻿using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
	public class GetProgressSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> progressGroup;

		public GetProgressSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.progressGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Progress, TweenyMatcher.Timer));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.progressGroup.GetEntities();
			int count = entities.Length;
		
			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.progress.Value = entity.timer.Current / entity.timer.Duration;
			}
		}
	}
}
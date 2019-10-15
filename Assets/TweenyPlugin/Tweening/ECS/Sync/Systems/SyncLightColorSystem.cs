using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncLightColorSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> lightGroup;

		public SyncLightColorSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.lightGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Light,
				TweenyMatcher.Color));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.lightGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.light.Light.color = entity.color.CurrentValue;
			}
		}
	}
}
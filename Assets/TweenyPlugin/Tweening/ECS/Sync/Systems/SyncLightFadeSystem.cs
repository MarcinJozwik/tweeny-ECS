using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncLightFadeSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> fadeGroup;

		public SyncLightFadeSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.fadeGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Light,
				TweenyMatcher.Fade, TweenyMatcher.Float));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.fadeGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				Color color = entity.light.Light.color;
				entity.light.Light.color = new Color(color.r, color.g, color.b, entity.@float.CurrentValue);
			}
		}
	}
}
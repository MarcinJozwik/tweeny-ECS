using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncMaterialFadeSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> fadeGroup;

		public SyncMaterialFadeSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.fadeGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Material,
				TweenyMatcher.Fade, TweenyMatcher.Float));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.fadeGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				Material material = entity.material.Material;
				material.color = new Color(material.color.r, material.color.g, material.color.b, entity.@float.CurrentValue);
			}
		}
	}
}
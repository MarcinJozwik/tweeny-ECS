using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncMaterialColorSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> materialGroup;

		public SyncMaterialColorSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.materialGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Material,
				TweenyMatcher.Color));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.materialGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.material.Material.color = entity.color.CurrentValue;
			}
		}
	}
}
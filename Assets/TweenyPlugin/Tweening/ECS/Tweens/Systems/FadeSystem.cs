using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Tweens.Systems
{
	public class FadeSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> fadeGroup;

		public FadeSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.fadeGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Material,
				TweenyMatcher.Fade, TweenyMatcher.Ease));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.fadeGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				float alpha = entity.fade.StartAlpha + entity.ease.Value * (entity.fade.EndAlpha - entity.fade.StartAlpha);
				Material material = entity.material.Material;
				material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
			}
		}
	}
}
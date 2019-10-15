using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Tweens.Systems
{
	public class TweenQuaternionSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> quaternionGroup;

		public TweenQuaternionSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.quaternionGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Quaternion, TweenyMatcher.Ease));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.quaternionGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.quaternion.CurrentValue = Quaternion.Lerp(entity.quaternion.StartValue,entity.quaternion.EndValue, entity.ease.Value);
			}
		}
	}
}
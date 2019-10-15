using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
    public class SyncTweenyQuaternionSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> quaternionGroup;

        public SyncTweenyQuaternionSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.quaternionGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening,
                TweenyMatcher.TweenyQuaternion,
                TweenyMatcher.Quaternion));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.quaternionGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.tweenyQuaternion.TweenyQuaternion.Value = entity.quaternion.CurrentValue;
            }
        }
    }
}
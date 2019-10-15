using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
    public class SyncTransformRotationSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> rotationGroup;

        public SyncTransformRotationSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.rotationGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening,
                TweenyMatcher.Rotate,
                TweenyMatcher.Quaternion, TweenyMatcher.Transform));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.rotationGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.transform.Transform.rotation = entity.quaternion.CurrentValue;
            }
        }
    }
}
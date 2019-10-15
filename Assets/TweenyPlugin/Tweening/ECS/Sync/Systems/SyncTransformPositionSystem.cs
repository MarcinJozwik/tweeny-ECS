using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
    public class SyncTransformPositionSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> moveGroup;

        public SyncTransformPositionSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.moveGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening,
                TweenyMatcher.Move,
                TweenyMatcher.Vector3, TweenyMatcher.Transform));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.moveGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.transform.Transform.position = entity.vector3.CurrentValue;
            }
        }
    }
}
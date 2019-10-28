using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
    public class SyncRectTransformPositionSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> moveGroup;

        public SyncRectTransformPositionSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.moveGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening,
                TweenyMatcher.Move,
                TweenyMatcher.Vector2, TweenyMatcher.RectTransform));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.moveGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.rectTransform.RectTransform.position = entity.vector2.CurrentValue;
            }
        }
    }
}
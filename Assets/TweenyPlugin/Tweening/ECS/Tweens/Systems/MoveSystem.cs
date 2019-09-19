using Entitas;

namespace TweenyPlugin.Tweening.ECS.Tweens.Systems
{
    public class MoveSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> moveGroup;

        public MoveSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.moveGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening,
                TweenyMatcher.Move,
                TweenyMatcher.Ease, TweenyMatcher.Transform));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.moveGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.transform.Transform.position = entity.move.StartPosition +
                                                      (entity.ease.Value * entity.move.Distance *
                                                       entity.move.Direction);
            }
        }
    }
}
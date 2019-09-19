using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
    public class CountTimeSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> tweenGroup;

        public CountTimeSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.tweenGroup =
                this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening,
                    TweenyMatcher.Timer));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.tweenGroup.GetEntities();
            int count = entities.Length;
        
            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                if (entity.timer.Timer >= entity.timer.Duration)
                {
                    entity.isFinish = true;
                }
            }
        }
    }
}
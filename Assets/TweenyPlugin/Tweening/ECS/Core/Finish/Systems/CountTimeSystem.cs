using Entitas;

namespace TweenyPlugin.Tweening.ECS.Core.Finish.Systems
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
                if (entity.timer.Current >= entity.timer.Duration)
                {
                    entity.isFinishing = true;
                }
            }
        }
    }
}
using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Core.Start.Systems
{
    public class TickTimerSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> timerGroup;

        public TickTimerSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.timerGroup =
                this.contexts.tweeny.GetGroup(TweenyMatcher
                    .AllOf(TweenyMatcher.Tweening, TweenyMatcher.Timer)
                    .NoneOf(TweenyMatcher.ResetMessage, TweenyMatcher.GoToMessage));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.timerGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.timer.Current = Mathf.MoveTowards(entity.timer.Current, entity.timer.Duration, contexts.tweeny.timeService.Instance.GetDeltaTime());
            }
        }
    }
}
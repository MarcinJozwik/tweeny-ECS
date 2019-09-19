using Entitas;
using UnityEngine;

namespace TweenyPlugin.Tweening.ECS.Core.Systems
{
    public class TickTimerSystem : IExecuteSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> timerGroup;

        public TickTimerSystem(Contexts contexts)
        {
            this.contexts = contexts;
            this.timerGroup =
                this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Timer));
        }

        public void Execute()
        {
            TweenyEntity[] entities = this.timerGroup.GetEntities();
            int count = entities.Length;

            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.timer.Timer = Mathf.MoveTowards(entity.timer.Timer, entity.timer.Duration, Time.deltaTime);
            }
        }
    }
}
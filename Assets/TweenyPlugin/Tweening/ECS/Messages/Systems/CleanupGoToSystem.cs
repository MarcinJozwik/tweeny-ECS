using Entitas;

namespace TweenyPlugin.Tweening.ECS.Messages.Systems
{
    public class CleanupGoToSystem : ICleanupSystem 
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> goToGroup;

        public CleanupGoToSystem(Contexts contexts) 
        {
            this.contexts = contexts;
            this.goToGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.GoToMessage).NoneOf(TweenyMatcher.DelayedMessage));
        }

        public void Cleanup()
        {
            TweenyEntity[] entities = this.goToGroup.GetEntities();
            int count = entities.Length;
		
            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.RemoveGoToMessage();

                if (!entity.hasTimeline)
                {
                    entity.isTweening = false;
                }
            }
        }
    }
}
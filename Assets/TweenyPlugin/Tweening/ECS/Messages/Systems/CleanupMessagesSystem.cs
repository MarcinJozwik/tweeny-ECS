using Entitas;

namespace TweenyPlugin.Tweening.ECS.Messages.Systems
{
    public class CleanupMessagesSystem : ICleanupSystem
    {
        private readonly Contexts contexts;
        private readonly IGroup<TweenyEntity> messageGroup;

        public CleanupMessagesSystem(Contexts contexts) 
        {
            this.contexts = contexts;
            this.messageGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Message, TweenyMatcher.Id));
        }
        
        public void Cleanup()
        {
            TweenyEntity[] entities = this.messageGroup.GetEntities();
            int count = entities.Length;
		
            for (int i = 0; i < count; i++)
            {
                TweenyEntity entity = entities[i];
                entity.Destroy();
            }
        }
    }
}
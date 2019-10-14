using Entitas;

public class CleanupResetSystem : ICleanupSystem 
{
    private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> resetGroup;

    public CleanupResetSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.resetGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.ResetMessage).NoneOf(TweenyMatcher.DelayedMessage));
    }

    public void Cleanup()
    {
        TweenyEntity[] entities = this.resetGroup.GetEntities();
        int count = entities.Length;
		
        for (int i = 0; i < count; i++)
        {
            TweenyEntity entity = entities[i];
            entity.isResetMessage = false;
            entity.isTweening = false;
        }
    }
}
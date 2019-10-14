using Entitas;

public class CleanupDelayedMessageSystem : ICleanupSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> playGroup;

    public CleanupDelayedMessageSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.playGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.DelayedMessage);
    }

	public void Cleanup()
	{
		TweenyEntity[] entities = this.playGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.isDelayedMessage = false;
		}
	}
}
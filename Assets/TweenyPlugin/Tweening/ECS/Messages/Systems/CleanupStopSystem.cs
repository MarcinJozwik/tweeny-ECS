using Entitas;

public class CleanupStopSystem : ICleanupSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> stopGroup;

    public CleanupStopSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.stopGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.StopMessage).NoneOf(TweenyMatcher.DelayedMessage));
    }

	public void Cleanup()
	{
		TweenyEntity[] entities = this.stopGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.isStopMessage = false;
		}
	}
}
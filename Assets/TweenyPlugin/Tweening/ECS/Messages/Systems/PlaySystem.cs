using Entitas;

public class PlaySystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> playGroup;

    public PlaySystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.playGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.PlayMessage).NoneOf(TweenyMatcher.Finished));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.playGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			
			entity.isTweening = true;
			
			if (!entity.isStarted)
			{
				entity.isStarting = true;
			}
		}
	}
}
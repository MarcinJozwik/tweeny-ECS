using Entitas;

public class StopSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> stopGroup;

    public StopSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.stopGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.StopMessage).NoneOf(TweenyMatcher.Finished));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.stopGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			
			entity.isTweening = false;

			if (entity.hasTimeline)
			{
				entity.isStopGroup = true;
			}

			entity.isStopMessage = false;
		}
	}
}
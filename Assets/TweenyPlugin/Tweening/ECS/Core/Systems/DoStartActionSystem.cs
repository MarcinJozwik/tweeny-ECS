using Entitas;

public class DoStartActionSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> startedGroup;

    public DoStartActionSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.startedGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Started, TweenyMatcher.Tweening, TweenyMatcher.StartAction));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.startedGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
		    TweenyEntity entity = entities[i];
		    entity.startAction.OnStart();
		    entity.RemoveStartAction();
		}
	}
}
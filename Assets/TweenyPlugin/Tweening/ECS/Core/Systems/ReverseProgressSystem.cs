using Entitas;

public class ReverseProgressSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> reverseGroup;

    public ReverseProgressSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.reverseGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Reverse, TweenyMatcher.Progress));
    }

    public void Execute()
    {
	    TweenyEntity[] entities = this.reverseGroup.GetEntities();
	    int count = entities.Length;
		
	    for (int i = 0; i < count; i++)
	    {
		    TweenyEntity entity = entities[i];
		    entity.progress.Value = 1 - entity.progress.Value;
	    }
    }
}
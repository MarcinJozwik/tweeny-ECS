using Entitas;

public class ReverseEaseSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> reverseGroup;

    public ReverseEaseSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.reverseGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Ease, TweenyMatcher.Reverse));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.reverseGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.ease.Value = 1 - entity.ease.Value;
		}
	}
}
using Entitas;

public class ChangeGroupIndexSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> timelineGroup;

    public ChangeGroupIndexSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.timelineGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Timeline, TweenyMatcher.Tweening, TweenyMatcher.GroupFinish));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.timelineGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];

			entity.timeline.ActiveGroupIndex++;
		}
	}
}
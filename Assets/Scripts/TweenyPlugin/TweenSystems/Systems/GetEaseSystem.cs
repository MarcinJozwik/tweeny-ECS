using Entitas;
using TweenyPlugin;

public class GetEaseSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> easeGroup;

    public GetEaseSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.easeGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Ease, TweenyMatcher.Timer, TweenyMatcher.Tweening));
    }

    public void Execute()
    {
	    TweenyEntity[] entities = this.easeGroup.GetEntities();
	    int count = entities.Length;
		
	    for (int i = 0; i < count; i++)
	    {
		    TweenyEntity entity = entities[i];
		    entity.ease.Value = Tweeny.GetValue(entity.timer.Timer, 0, entity.timer.Duration, entity.ease.Type);
	    }
    }
}
using Entitas;

public class GoToSystem : IExecuteSystem 
{
    private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> goToGroup;

    public GoToSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.goToGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.GoToMessage));
    }

    public void Execute()
    {
        TweenyEntity[] entities = this.goToGroup.GetEntities();
        int count = entities.Length;
		
        for (int i = 0; i < count; i++)
        {
            TweenyEntity entity = entities[i];

            if (entity.hasTimer)
            {
                entity.isTweening = true;
                entity.timer.Current = entity.goToMessage.Step * entity.timer.Duration;
            }
        }
    }
}
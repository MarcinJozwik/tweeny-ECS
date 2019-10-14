using Entitas;
using TweenyPlugin.Tweening.ECS.Utilities;

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
                entity.timer.Current = entity.goToMessage.Step;
            }

            if (entity.hasTimeline)
            {
                if (entity.hasGoToGroup)
                {
                    entity.goToGroup.Step = entity.goToMessage.Step;
                }
                else
                {
                    entity.AddGoToGroup(entity.goToMessage.Step);
                }
            }

            entity.RemoveGoToMessage();
        }
    }
}
using Entitas;

public class EndTweenSystem : IExecuteSystem
{
    private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> tweenGroup;

    public EndTweenSystem(Contexts contexts)
    {
        this.contexts = contexts;
        this.tweenGroup =
            this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Timer,
                TweenyMatcher.Tweening));
    }

    public void Execute()
    {
        TweenyEntity[] entities = this.tweenGroup.GetEntities();
        int count = entities.Length;
        
        for (int i = 0; i < count; i++)
        {
            TweenyEntity entity = entities[i];
            if (entity.timer.Timer >= entity.timer.Duration)
            {
                entity.isTweening = false;
            }
        }
    }
}
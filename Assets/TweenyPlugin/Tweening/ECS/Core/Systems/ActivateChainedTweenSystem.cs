using Entitas;

public class ActivateChainedTweenSystem : IExecuteSystem
{
    private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> chainedGroup;

    public ActivateChainedTweenSystem(Contexts contexts)
    {
        this.contexts = contexts;
        this.chainedGroup = this.contexts.tweeny.GetGroup(
            TweenyMatcher.AllOf(TweenyMatcher.ChainedTween, TweenyMatcher.Tweening,
                TweenyMatcher.Finish));
    }

    public void Execute()
    {
        TweenyEntity[] entities = this.chainedGroup.GetEntities();
        int count = entities.Length;
        
        for (int i = 0; i < count; i++)
        {
            TweenyEntity chainedEntity = this.contexts.tweeny.GetEntityWithId(entities[i].chainedTween.Id);
            chainedEntity.isTweening = true;
        }
    }
}
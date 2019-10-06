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
            int idCount = entities[i].chainedTween.Ids.Count;
            for (int j = 0; j < idCount; j++)
            {
                TweenyEntity entity = entities[i];
                
                TweenyEntity chainedEntity = this.contexts.tweeny.GetEntityWithId(entity.chainedTween.Ids[j]);
                chainedEntity.isStarted = true;
                chainedEntity.isTweening = true;
                
                entity.chainedTween.OnChained();
            }
        }
    }
}
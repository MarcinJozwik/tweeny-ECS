using Entitas;
using TweenyPlugin.Tweening.ECS.Utilities;

public class ResetSystem : IExecuteSystem 
{
    private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> resetGroup;

    public ResetSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.resetGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.ResetMessage));
    }

    public void Execute()
    {
        TweenyEntity[] entities = this.resetGroup.GetEntities();
        int count = entities.Length;
		
        for (int i = 0; i < count; i++)
        {
            TweenyEntity entity = entities[i];

            if (entity.hasTimer)
            {
                entity.timer.Current = 0;
            }

            if (entity.hasLoop && entity.loop.BaseAmount != -1)
            {
                bool oddDifference = (entity.loop.BaseAmount - entity.loop.Count) % 2 == 1;

                if (oddDifference)
                {
                    if (entity.loop.Type == LoopType.PingPong)
                    {
                        entity.isMirror = !entity.isMirror;
                    }
                    else if (entity.loop.Type == LoopType.Reverse)
                    {
                        entity.isReverse = !entity.isReverse;
                    }
                }
                
                if (entity.hasBetweenLoops)
                {
                    entity.RemoveBetweenLoops();
                    entity.isTweening = true;
                }
                
                entity.loop.Count = entity.loop.BaseAmount;
            }
        }
    }
}
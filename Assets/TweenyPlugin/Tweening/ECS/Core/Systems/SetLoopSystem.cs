using Entitas;
using TweenyPlugin.Tweening.ECS.Utilities;

public class SetLoopSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> loopGroup;

    public SetLoopSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.loopGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Loop, TweenyMatcher.Finishing, TweenyMatcher.Timer));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.loopGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			int loopsLeft = entity.loop.Count;
			
			if (loopsLeft > 1 || loopsLeft == -1)
			{
				entity.timer.Current = 0;
				entity.isFinishing = false;

				if (entity.loop.Type == LoopType.PingPong)
				{
					entity.isMirror = !entity.isMirror;
				}
				else if (entity.loop.Type == LoopType.Reverse)
				{
					entity.isReverse = !entity.isReverse;
				}

				if (entity.loop.DelayBetweenLoops != 0f)
				{
					entity.AddDelay(entity.loop.DelayBetweenLoops, 0f);
				}
			}

			if (loopsLeft > 1)
			{
				entity.loop.Count--;
			}
		}
	}
}
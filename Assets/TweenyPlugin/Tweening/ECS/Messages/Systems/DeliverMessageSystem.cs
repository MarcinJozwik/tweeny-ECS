using Entitas;
using UnityEngine;

public class DeliverMessageSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> messageGroup;

    public DeliverMessageSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.messageGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Message, TweenyMatcher.ReceiverId));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.messageGroup.GetEntities();
		int count = entities.Length;
		
		for (int i = 0; i < count; i++)
		{
		    TweenyEntity message = entities[i];
		    TweenyEntity receiver = this.contexts.tweeny.GetEntityWithId(message.receiverId.Id);

		    #region Play

		    if (message.isPlayMessage)
		    {
			    receiver.isStarted = true;
			    receiver.isTweening = true;
		    }

		    #endregion

		    #region Stop

		    if (message.isStopMessage)
		    {
			    receiver.isTweening = false;
		    }

		    #endregion
		    
		    #region Reset

		    if (message.isResetMessage)
		    {
			    if (receiver.hasTimer)
			    {
				    receiver.timer.Current = 0;
			    }
		    }

		    #endregion

		    #region Chained Tween
		    
		    if (message.hasChainedTween)
		    {
			    if (receiver.hasChainedTween)
			    {
				    receiver.chainedTween.Ids = message.chainedTween.Ids;
				    receiver.chainedTween.OnChained = message.chainedTween.OnChained;
				    Debug.LogWarning(
					    $"Overwriting ChainTween method for tween: {message.receiverId.Id}. Have you used the same method twice on purpose?");
			    }
			    else
			    {
				    receiver.AddChainedTween(message.chainedTween.Ids, message.chainedTween.OnChained);
			    }
		    }
		    
		    #endregion
		}
	}
}
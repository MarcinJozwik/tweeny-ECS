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

		    if (receiver == null)
		    {
			    Debug.Log($"Receiver of a message doesn't exist anymore: ID: {message.receiverId.Id}");
			    continue;
		    }

		    if (message.isPlayMessage)
		    {
			    receiver.isTweening = true;
		    }
		    
		    if (message.isStopMessage)
		    {
			    receiver.isTweening = false;
		    }

		    if (message.hasCompleteAction)
		    {
			    receiver.AddCompleteAction(message.completeAction.OnComplete);
		    }
		    
		    if (message.hasCompleteLoopAction)
		    {
			    receiver.AddCompleteLoopAction(message.completeLoopAction.OnLoopComplete);
		    }

		    if (message.hasLoop)
		    {
			    receiver.AddLoop(message.loop.Count, message.loop.Type);
		    }

		    if (message.isReverse)
		    {
			    receiver.isReverse = true;
		    }
		    
		    if (message.isMirror)
		    {
			    receiver.isMirror = true;
		    }
		    
		    if (message.hasChainedTween)
		    {
			    receiver.AddChainedTween(message.chainedTween.Id);
		    }
		}
	}
}
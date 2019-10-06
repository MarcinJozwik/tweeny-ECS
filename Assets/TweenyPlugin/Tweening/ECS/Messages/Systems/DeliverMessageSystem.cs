﻿using Entitas;
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
			    receiver.isTweening = true;
		    }

		    #endregion

		    #region Stop

		    if (message.isStopMessage)
		    {
			    receiver.isTweening = false;
		    }

		    #endregion

		    #region OnComplete

		    if (message.hasCompleteAction)
		    {
			    if (receiver.hasCompleteAction)
			    {
				    receiver.completeAction.OnComplete = message.completeAction.OnComplete;
				    Debug.LogWarning(
					    $"Overwriting OnComplete callback for tween: {message.receiverId.Id}. Have you used the same method twice on purpose?");
			    }
			    else
			    {
				    receiver.AddCompleteAction(message.completeAction.OnComplete);
			    }
		    }

		    #endregion

		    #region OnCompleteLoop

		    if (message.hasCompleteLoopAction)
		    {
			    if (receiver.hasCompleteLoopAction)
			    {
				    receiver.completeLoopAction.OnLoopComplete = message.completeLoopAction.OnLoopComplete;
				    Debug.LogWarning(
					    $"Overwriting OnCompleteLoop callback for tween: {message.receiverId.Id}. Have you used the same method twice on purpose?");
			    }
			    else
			    {
				    receiver.AddCompleteLoopAction(message.completeLoopAction.OnLoopComplete);
			    }
		    }

		    #endregion

		    #region SetLoop

		    if (message.hasLoop)
		    {
			    if (receiver.hasLoop)
			    {
				    receiver.loop.Count = message.loop.Count;
				    receiver.loop.Type = message.loop.Type;
				    Debug.LogWarning(
					    $"Overwriting SetLoop method for tween: {message.receiverId.Id}. Have you used the same method twice on purpose?");
			    }
			    else
			    {
				    receiver.AddLoop(message.loop.Count, message.loop.Type);
			    }
		    }

		    #endregion

		    #region Reverse

		    if (message.isReverse)
		    {
			    receiver.isReverse = true;
		    }

		    #endregion

		    #region Mirror

		    if (message.isMirror)
		    {
			    receiver.isMirror = true;
		    }

		    #endregion

		    #region Chained Tween
		    
		    if (message.hasChainedTween)
		    {
			    if (receiver.hasChainedTween)
			    {
				    receiver.chainedTween.Id = message.chainedTween.Id;
				    Debug.LogWarning(
					    $"Overwriting ChainTween method for tween: {message.receiverId.Id}. Have you used the same method twice on purpose?");
			    }
			    else
			    {
				    receiver.AddChainedTween(message.chainedTween.Id);
			    }
		    }
		    
		    #endregion
		}
	}
}
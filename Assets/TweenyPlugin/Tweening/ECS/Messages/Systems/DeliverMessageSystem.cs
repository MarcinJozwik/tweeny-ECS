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
			    receiver.isStarting = true;
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

		    #region Timeline

		    if (message.isGroupFinish)
		    {
			    receiver.isGroupFinish = true;
		    }

		    #endregion
		}
	}
}
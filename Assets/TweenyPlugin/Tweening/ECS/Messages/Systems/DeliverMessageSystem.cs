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
			    receiver.isPlayMessage = true;
		    }

		    #endregion

		    #region Stop

		    if (message.isStopMessage)
		    {
			    receiver.isStopMessage = true;
		    }

		    #endregion
		    
		    #region Reset

		    if (message.isResetMessage)
		    {
			    receiver.isResetMessage = true;
		    }

		    #endregion
		}
	}
}
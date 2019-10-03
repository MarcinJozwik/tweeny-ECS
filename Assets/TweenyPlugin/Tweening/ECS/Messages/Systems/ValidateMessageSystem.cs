using Entitas;

public class ValidateMessageSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> messageGroup;

    public ValidateMessageSystem(Contexts contexts) 
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
			    message.Destroy();
		    }
	    }
    }
}
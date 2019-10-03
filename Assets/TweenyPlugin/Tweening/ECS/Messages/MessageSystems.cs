using TweenyPlugin.Tweening.ECS.Messages.Systems;

namespace TweenyPlugin.Tweening.ECS.Messages
{
    public class MessageSystems : Feature
    {
        public MessageSystems(Contexts contexts) : base("Message Systems")
        {
            this.Add(new ValidateMessageSystem(contexts));
            this.Add(new DeliverMessageSystem(contexts));
            this.Add(new CleanupMessagesSystem(contexts));
        }
    }
}
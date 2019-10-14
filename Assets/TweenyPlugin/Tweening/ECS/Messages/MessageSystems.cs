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
            this.Add(new PlaySystem(contexts));
            this.Add(new StopSystem(contexts));
            this.Add(new ResetSystem(contexts));
            this.Add(new GoToSystem(contexts));
            
            this.Add(new CleanupPlaySystem(contexts));
            this.Add(new CleanupStopSystem(contexts));
            this.Add(new CleanupResetSystem(contexts));
            this.Add(new CleanupGoToSystem(contexts));
            this.Add(new CleanupDelayedMessageSystem(contexts));
        }
    }
}
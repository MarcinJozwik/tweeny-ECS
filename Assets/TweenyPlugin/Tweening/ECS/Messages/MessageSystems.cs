using TweenyPlugin.Tweening.ECS.Core.Timeline.Systems;
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
        }
    }
}
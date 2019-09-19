using Entitas;
using TweenyPlugin.Tweening.ECS.Core;
using TweenyPlugin.Tweening.ECS.Index;
using TweenyPlugin.Tweening.ECS.Messages;
using TweenyPlugin.Tweening.ECS.Tweens;
using UnityEngine;

namespace TweenyPlugin.Tweening.Link
{
    public class TweenManager : MonoBehaviour
    {
        private Contexts contexts;
        private Systems systems;

        private void Start()
        {
            this.contexts = Contexts.sharedInstance;
            this.contexts.SubscribeId();
            this.systems = new Feature("Systems")
                .Add(new MessageSystems(contexts))
                .Add(new CoreSystems(contexts))
                .Add(new TweenSystems(contexts));
        }
        
        private void Update()
        {
            this.systems.Execute();
            this.systems.Cleanup();
        }
    }
}
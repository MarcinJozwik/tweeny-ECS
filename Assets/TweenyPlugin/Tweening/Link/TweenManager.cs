using Entitas;
using TweenyPlugin.Tweening.ECS.Index;
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
            this.systems = new TweenSystems(contexts);
        }
        
        private void Update()
        {
            this.systems.Execute();
            this.systems.Cleanup();
        }
    }
}
using Entitas;
using TweenyPlugin.TweenSystems.Index;
using UnityEngine;

namespace TweenyPlugin.TweenSystems
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
using Entitas;
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
            this.systems = new TweenSystems(contexts);
        }
        
        private void Update()
        {
            this.systems.Execute();
            this.systems.Cleanup();
        }
    }
}
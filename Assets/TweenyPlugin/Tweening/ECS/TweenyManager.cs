﻿using Entitas;
using TweenyPlugin.Tweening.ECS.Index;

namespace TweenyPlugin.Tweening.ECS
{
    public class TweenyManager
    {
        private Contexts contexts;
        private Systems systems;

        public void Init()
        {
            this.contexts = Contexts.sharedInstance;
            this.contexts.SubscribeId();
            this.systems = new TweenySystems(contexts);
        }
        
        public void OnUpdate()
        {
            this.systems.Execute();
            this.systems.Cleanup();
        }
    }
}
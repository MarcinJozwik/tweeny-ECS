using System;
using Entitas;
using TweenyPlugin.Tweening.ECS.Index.Components;

namespace TweenyPlugin.Tweening.ECS.Index
{
    public static class ContextsIdExtensions
    {
        public static void SubscribeId(this Contexts contexts)
        {
            for (int i = 0; i < contexts.allContexts.Length; i++)
            {
                IContext context = contexts.allContexts[i];
                if (Array.FindIndex(context.contextInfo.componentTypes, v => v == typeof(IdComponent)) >= 0)
                {
                    context.OnEntityCreated += AddId;
                }
            }
        }

        public static void AddId(IContext context, IEntity entity)
        {
            (entity as IIdEntity)?.ReplaceId(entity.creationIndex);
        }
    }
}
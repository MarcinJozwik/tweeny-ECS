using System.Collections.Generic;
using UnityEngine;

namespace TweenyPlugin
{
    public class TweenyCollector
    {
        private static readonly List<Tween> tweens = new List<Tween>();
        
        public static void Register(Tween tween)
        {
            tweens.Add(tween);
        }
        
        public static void Unregister(Tween tween)
        {
            tweens.Remove(tween);
        }

        public static void Update(float deltaTime)
        {
            //Debug.Log("Tweens: " + tweens.Count);
            
            for (var i = 0; i < tweens.Count; i++)
            {
                var tween = tweens[i];
                if (!tween.Finished)
                {
                    tween.Update(deltaTime);
                }
            }
        }
    }
}
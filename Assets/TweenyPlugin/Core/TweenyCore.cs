using System;
using System.Collections.Generic;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

namespace TweenyPlugin.Core
{
    public static partial class Tweeny
    {
        private static TweenyEntity CreateBase(float duration, Ease ease, TweenSet set)
        {
            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
            
            entity.AddTimer(0f, duration);
            entity.AddProgress(0f);
            entity.AddEase(ease, 0f);
            
            if (set != null)
            {
                ApplySet(entity, set);
            }
            
            return entity;
        }
        
        public static Tuple<int, float> BuildTimeline(List<int[]> groups, TweenSet set)
        {
            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
            entity.AddTimeline(0, groups[0], groups);
            
            if (set != null)
            {
                ApplySet(entity, set);
            }
            
            return new Tuple<int, float>(entity.id.Value, CountTimelineDuration(entity));
        }

        private static void ApplySet(TweenyEntity entity, TweenSet set)
        {
            if (set.OnCompleteAction != null)
            {
                entity.AddCompleteAction(set.OnCompleteAction);
            }
            
            if (set.OnStartAction != null)
            {
                entity.AddStartAction(set.OnStartAction);
            }
            
            if (set.OnLoopCompleteAction != null)
            {
                entity.AddCompleteLoopAction(set.OnLoopCompleteAction);
            }

            if (set.Loops != 0)
            {
                entity.AddLoop(set.Loops,set.Loops, set.LoopType, set.DelayBetweenLoops);
            }
            
            if (set.InitialDelay > 0)
            {
                entity.AddDelay(set.InitialDelay, 0f);
            }
            
            entity.isReverse = set.IsReversed;
            entity.isMirror = set.IsMirrored;
        }

        private static float CountTimelineDuration(TweenyEntity timeline)
        {
            float totalDuration = 0;
            float maxGroupDuration = 0;

            int totalCount = timeline.timeline.Groups.Count;
            
            for (int i = 0; i < totalCount; i++)
            {
                int[] group = timeline.timeline.Groups[i];
                int groupCount = group.Length;
                for (int j = 0; j < groupCount; j++)
                {
                    TweenyEntity tween = Contexts.sharedInstance.tweeny.GetEntityWithId(group[j]);
                    float duration = CountDuration(tween);
                    if (duration > maxGroupDuration)
                    {
                        maxGroupDuration = duration;
                    }
                }

                totalDuration += maxGroupDuration;
                maxGroupDuration = 0;
            }
            Debug.Log($"Count: {totalCount}, duration {totalDuration}");
            return totalDuration;
        }

        private static float CountDuration(TweenyEntity entity)
        {
            float duration = entity.timer.Duration;
            float initialDelay = entity.hasDelay ? entity.delay.Delay : 0f;
            int loops = entity.hasLoop ? entity.loop.BaseAmount : 1;
            float delayBetweenLoops = entity.hasLoop ? entity.loop.DelayBetweenLoops : 0f;
            
            return initialDelay + (duration * loops) + (delayBetweenLoops * (loops - 1));
        }

        private static Tween GetTween(TweenyEntity entity)
        {
            return new Tween(entity.id.Value, CountDuration(entity));
        }
    }
}
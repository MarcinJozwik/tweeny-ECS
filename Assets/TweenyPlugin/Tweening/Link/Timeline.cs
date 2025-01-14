﻿using System;
using System.Collections.Generic;
using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using UnityEngine;

namespace TweenyPlugin.Tweening.Link
{
    public class Timeline : ITweenable
    {
        #region Fields

        private readonly List<int[]> groups = new List<int[]>();
        private readonly TweenyContext context;

        private int id;
        private float duration;
        private bool built = false;

        #endregion

        #region Contructor

        public Timeline()
        {
            context = Contexts.sharedInstance.tweeny;
        }

        #endregion
        #region Build

        public void AddGroup(params ITweenable[] tweens)
        {
            if (Validate())
            {
                groups.Add(GetIds(tweens));
            }
        }
        
        public void InsertGroup(int index, params ITweenable[] tweens)
        {
            if (Validate())
            {
                groups.Insert(index, GetIds(tweens));
            }
        }
        
        public void AddDelay(float delay, TweenSet set = null)
        {
            if (Validate())
            {
                Tween delayTween = Tweeny.TBase(delay, EaseMode.Linear, set);
                groups.Add(new[] {delayTween.GetId()});
            }
        }

        public void Build(TweenSet set = null)
        {
            Tuple<int, float> values = Tweeny.BuildTimeline(groups, set);
            id = values.Item1;
            duration = values.Item2;
            built = true;
        }

        private bool Validate()
        {
            if (built)
            {
                Debug.LogError("Trying to change timeline elements after build. This not allowed.");
            }
            
            return !built;
        }

        private int[] GetIds(ITweenable[] tweens)
        {
            int [] ids = new int[tweens.Length];
            for (var i = 0; i < tweens.Length; i++)
            {
                ids[i] = tweens[i].GetId();
            }
            return ids;
        }

        #endregion

        #region Run-time control

        public void Play()
        {
            if (!built)
            {
                Debug.LogError("Trying to play not built timeline. Use Build() method to end the creation process first.");
                return;
            }
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isPlayMessage = true;
            message.isMessage = true;
        }

        public void Stop()
        {
            if (!built)
            {
                Debug.LogError("Trying to stop not built timeline. Use Build() method to end the creation process first.");
                return;
            }
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isStopMessage = true;
            message.isMessage = true;
        }

        public void Reset()
        {
            if (!built)
            {
                Debug.LogError("Trying to stop not built timeline. Use Build() method to end the creation process first.");
                return;
            }
            
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.isResetMessage = true;
            message.isMessage = true;
        }

        public void GoTo(float step)
        {
            TweenyEntity message = context.CreateEntity();
            message.AddReceiverId(id);
            message.AddGoToMessage(step);
            message.isMessage = true;
        }

        public bool IsFinished()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                return entity.isFinished;
            }

            return true;
        }

        public bool IsPlaying()
        {
            var entity = context.GetEntityWithId(id);
            if (entity != null)
            {
                return entity.isTweening && !IsFinished();
            }

            return false;
        }

        public float GetTotalDuration()
        {
            return duration;
        }

        public int GetId()
        {
            return id;
        }

        #endregion
    }
}
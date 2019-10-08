using System;
using System.Collections.Generic;

namespace TweenyPlugin.Tweening.Link
{
    public class Timeline : ITweenable
    {
        private readonly List<Tween[]> groups = new List<Tween[]>();
        private int activeGroupIndex = 0;
        private bool reversed = false;
        private bool playing = false;

        public void AddGroup(params Tween[] tweens)
        {
            groups.Add(tweens);
            SetGroupCallback(GetLongestTween(tweens));
        }
        
        public void AddDelay(float delay)
        {
            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
            entity.AddTimer(0f, delay);
            Tween delayTween = new Tween(entity.id.Value, delay);
            groups.Add(new[] {delayTween});
            SetGroupCallback(delayTween);
        }

        public void Play()
        {
            if (IsFinished())
            {
                return;
            }

            int count = GetGroup().Length;
            
            for (var i = 0; i < count; i++)
            {
                Tween tween = GetGroup()[i];
                tween.Play();
            }

            playing = true;
        }

        public void Stop()
        {
            if (IsFinished())
            {
                return;
            }

            int count = GetGroup().Length;
            
            for (var i = 0; i < count; i++)
            {
                Tween tween = GetGroup()[i];
                tween.Stop();
            }
            
            playing = false;
        }

        private Tween GetLongestTween(Tween[] tweens)
        {
            Tween longestTween = null;
            float longestDuration = -1;

            for (var i = 0; i < tweens.Length; i++)
            {
                Tween tween = tweens[i];
                float duration = tween.GetTotalDuration();
                if (duration >= longestDuration)
                {
                    longestDuration = duration;
                    longestTween = tween;
                }
            }

            return longestTween;
        }
        
        private void SetGroupCallback(Tween tween)
        {
            TweenyEntity message = Contexts.sharedInstance.tweeny.CreateEntity();
            message.AddReceiverId(tween.GetId());
            message.AddChainedTween(null, OnGroupComplete);
            message.isMessage = true;
        }

        public Timeline Backwards()
        {
            reversed = true;
            return this;
        }
        
        public bool IsFinished()
        {
            return activeGroupIndex >= groups.Count;
        }

        public bool IsPlaying()
        {
            return playing && !IsFinished();
        }

        public float GetTotalDuration()
        {
            float duration = 0;

            for (var i = 0; i < groups.Count; i++)
            {
                duration += GetLongestTween(groups[i]).GetTotalDuration();
            }

            return duration;
        }

        private Tween[] GetGroup()
        {
            return groups[GetIndex()];
        }

        private int GetIndex()
        {
            return reversed ? (groups.Count - 1 - activeGroupIndex) : activeGroupIndex;
        }
        
        private void OnGroupComplete()
        {
            activeGroupIndex++;
            Play();
        }
    }
}
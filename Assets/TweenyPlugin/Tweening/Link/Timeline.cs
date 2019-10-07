using System.Collections.Generic;

namespace TweenyPlugin.Tweening.Link
{
    public class Timeline
    {
        private readonly List<Tween[]> groups = new List<Tween[]>();
        private int activeGroupIndex = 0;

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
        }

        public bool IsFinished()
        {
            return activeGroupIndex >= groups.Count;
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

        private Tween[] GetGroup()
        {
            return groups[activeGroupIndex];
        }

        private void OnGroupComplete()
        {
            activeGroupIndex++;
            Play();
        }
    }
}
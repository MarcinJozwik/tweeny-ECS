using System.Collections.Generic;

namespace TweenyPlugin.Tweening.Link
{
    public class Timeline
    {
        private readonly List<Tween[]> groups = new List<Tween[]>();
        private int activeGroupIndex;

        public void AddGroup(params Tween[] tweens)
        {
            groups.Add(tweens);

            if (groups.Count > 1)
            {
                ConnectGroups();
            }
        }
        
        public void AddDelay(float delay)
        {
            TweenyEntity entity = Contexts.sharedInstance.tweeny.CreateEntity();
            entity.AddTimer(0f, delay);
            groups.Add(new[] { new Tween(entity.id.Value, delay)});
            if (groups.Count > 1)
            {
                ConnectGroups();
            }
        }

        public void Play()
        {
            if (IsFinished())
            {
                return;
            }

            int count = groups[activeGroupIndex].Length;
            
            for (var i = 0; i < count; i++)
            {
                Tween tween = groups[activeGroupIndex][i];
                tween.Play();
            }
        }

        public void Stop()
        {
            if (IsFinished())
            {
                return;
            }

            int count = groups[activeGroupIndex].Length;
            
            for (var i = 0; i < count; i++)
            {
                Tween tween = groups[activeGroupIndex][i];
                tween.Stop();
            }
        }

        public bool IsFinished()
        {
            return false;//activeGroupIndex >= groups.Count;
        }

        private void ConnectGroups()
        {
            Tween[] previousGroup = groups[groups.Count - 2];
            Tween[] latestGroup = groups[groups.Count - 1];
            
            Tween longestTween = null;
            float longestDuration = -1;
            
            foreach (Tween tween in previousGroup)
            {
                float duration = tween.GetTotalDuration();
                if (duration >= longestDuration)
                {
                    longestDuration = duration;
                    longestTween = tween;
                }
            }
            
            ChainTweens(longestTween, latestGroup);
        }
        
        private void ChainTweens(Tween rootTween, Tween[] tweens)
        {
            List<int> ids = new List<int>();

            for (var i = 0; i < tweens.Length; i++)
            {
                var tween = tweens[i];
                ids.Add(tween.GetId());
            }

            TweenyEntity message = Contexts.sharedInstance.tweeny.CreateEntity();
            message.AddReceiverId(rootTween.GetId());
            message.AddChainedTween(ids, OnGroupComplete);
            message.isMessage = true;
        }

        private void OnGroupComplete()
        {
            activeGroupIndex++;
        }
    }
}
using System.Collections.Generic;

namespace TweenyPlugin.Tweening.Link
{
    public class Timeline
    {
        private readonly List<Tween[]> groups = new List<Tween[]>();

        public void AddGroup(params Tween[] tweens)
        {
            groups.Add(tweens);

            if (groups.Count > 1)
            {
                ConnectGroups();
            }
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

            longestTween.Next(latestGroup);
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
            foreach (Tween tween in groups[0])
            {
                tween.Play();
            }   
        }

//        private float GetTotalDuration(Tween tween)
//        {
//            float initialDelay = 0f, duration = 0f, delayBetweenLoops = 0f;
//            int loops = 1;
//            
//            TweenyEntity entity = Contexts.sharedInstance.tweeny.GetEntityWithId(tween.GetId());
//
//            duration = entity.timer.Duration;
//
//            if (entity.hasDelay)
//            {
//                initialDelay = entity.delay.Delay;
//            }
//
//            if (entity.hasLoop)
//            {
//                loops = entity.loop.Count;
//                delayBetweenLoops = entity.loop.DelayBetweenLoops;
//            }
//
//            if (loops == -1)
//            {
//                Debug.LogWarning($"Creating timeline with infinite tween inside! Tween id: {tween.GetId()}");
//                return float.MaxValue;
//            }
//
//            return initialDelay + (duration * loops) + (delayBetweenLoops * (loops - 1));
//        }
    }
}
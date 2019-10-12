using TweenyPlugin.Tweening.ECS.TimeService;

namespace TweenyPlugin.Tweening.Unity
{
    public class UnityTimeService : ITimeService
    {
        public void SetTimeScale(float newTimeScale)
        {
            UnityEngine.Time.timeScale = newTimeScale;
        }

        public float GetTimeScale()
        {
            return UnityEngine.Time.timeScale;
        }

        public float GetDeltaTime()
        {
            return UnityEngine.Time.deltaTime;
        }

        public float GetCurrentTime()
        {
            return UnityEngine.Time.timeSinceLevelLoad;
        }
    }
}
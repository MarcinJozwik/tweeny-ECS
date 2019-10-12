namespace TweenyPlugin.Tweening.ECS.TimeService
{
    public interface ITimeService
    {
        void SetTimeScale(float newTimeScale);

        float GetTimeScale();

        float GetDeltaTime();

        float GetCurrentTime();
    }
}
namespace TweenyPlugin.Tweening.Link
{
    public interface ITweenable
    {
        void Play();
        void Stop();
        void Reset();
        bool IsFinished();
        bool IsPlaying();
        float GetTotalDuration();
    }
}
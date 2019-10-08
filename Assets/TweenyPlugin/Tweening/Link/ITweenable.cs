namespace TweenyPlugin.Tweening.Link
{
    public interface ITweenable
    {
        void Play();
        void Stop();
        bool IsFinished();
        bool IsPlaying();
        float GetTotalDuration();
    }
}
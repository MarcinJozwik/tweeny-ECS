namespace TweenyPlugin.Tweening.Link
{
    public interface ITweenable
    {
        void Play();
        void Stop();
        void Reset();
        void GoTo(float step); 
        bool IsFinished();
        bool IsPlaying();
        float GetTotalDuration();

        int GetId();
    }
}
using System;
using TweenyPlugin.Utilities;

namespace TweenyPlugin.Tweening.Link
{
    public interface ITweenSet <out T> where T : class
    {
        T Reverse();
        T Mirror();

        T SetLoops(int loops, LoopType type = LoopType.Restart, float delayBetweenLoops = 0f);
        T SetDelay(float delay);

        T OnStart(Action action);
        T OnLoopComplete(Action action);
        T OnComplete(Action action);
    }
}
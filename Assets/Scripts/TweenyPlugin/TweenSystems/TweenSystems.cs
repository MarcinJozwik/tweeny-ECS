namespace TweenyPlugin.TweenSystems
{
    public class TweenSystems : Feature
    {
        public TweenSystems(Contexts contexts)
            : base("Tween Systems")
        {
            this.Add(new TickTimerSystem(contexts));
            this.Add(new GetEaseSystem(contexts));
            this.Add(new MoveSystem(contexts));
            this.Add(new ScaleSystem(contexts));
            this.Add(new FadeSystem(contexts));
            this.Add(new CountTimeSystem(contexts));
            this.Add(new DoCompleteActionSystem(contexts));
            this.Add(new FinishTweenSystem(contexts));
        }
    }
}
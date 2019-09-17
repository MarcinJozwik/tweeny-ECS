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
            this.Add(new EndTweenSystem(contexts));
        }
    }
}
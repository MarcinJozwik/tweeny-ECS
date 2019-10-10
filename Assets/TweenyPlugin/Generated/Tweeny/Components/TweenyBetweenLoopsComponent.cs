//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public BetweenLoopsComponent betweenLoops { get { return (BetweenLoopsComponent)GetComponent(TweenyComponentsLookup.BetweenLoops); } }
    public bool hasBetweenLoops { get { return HasComponent(TweenyComponentsLookup.BetweenLoops); } }

    public void AddBetweenLoops(float newTimer) {
        var index = TweenyComponentsLookup.BetweenLoops;
        var component = (BetweenLoopsComponent)CreateComponent(index, typeof(BetweenLoopsComponent));
        component.Timer = newTimer;
        AddComponent(index, component);
    }

    public void ReplaceBetweenLoops(float newTimer) {
        var index = TweenyComponentsLookup.BetweenLoops;
        var component = (BetweenLoopsComponent)CreateComponent(index, typeof(BetweenLoopsComponent));
        component.Timer = newTimer;
        ReplaceComponent(index, component);
    }

    public void RemoveBetweenLoops() {
        RemoveComponent(TweenyComponentsLookup.BetweenLoops);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TweenyMatcher {

    static Entitas.IMatcher<TweenyEntity> _matcherBetweenLoops;

    public static Entitas.IMatcher<TweenyEntity> BetweenLoops {
        get {
            if (_matcherBetweenLoops == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.BetweenLoops);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherBetweenLoops = matcher;
            }

            return _matcherBetweenLoops;
        }
    }
}

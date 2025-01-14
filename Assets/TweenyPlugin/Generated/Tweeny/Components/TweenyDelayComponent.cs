//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public TweenyPlugin.Tweening.ECS.Core.Start.Components.DelayComponent delay { get { return (TweenyPlugin.Tweening.ECS.Core.Start.Components.DelayComponent)GetComponent(TweenyComponentsLookup.Delay); } }
    public bool hasDelay { get { return HasComponent(TweenyComponentsLookup.Delay); } }

    public void AddDelay(float newDelay, float newTimer) {
        var index = TweenyComponentsLookup.Delay;
        var component = (TweenyPlugin.Tweening.ECS.Core.Start.Components.DelayComponent)CreateComponent(index, typeof(TweenyPlugin.Tweening.ECS.Core.Start.Components.DelayComponent));
        component.Delay = newDelay;
        component.Timer = newTimer;
        AddComponent(index, component);
    }

    public void ReplaceDelay(float newDelay, float newTimer) {
        var index = TweenyComponentsLookup.Delay;
        var component = (TweenyPlugin.Tweening.ECS.Core.Start.Components.DelayComponent)CreateComponent(index, typeof(TweenyPlugin.Tweening.ECS.Core.Start.Components.DelayComponent));
        component.Delay = newDelay;
        component.Timer = newTimer;
        ReplaceComponent(index, component);
    }

    public void RemoveDelay() {
        RemoveComponent(TweenyComponentsLookup.Delay);
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

    static Entitas.IMatcher<TweenyEntity> _matcherDelay;

    public static Entitas.IMatcher<TweenyEntity> Delay {
        get {
            if (_matcherDelay == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Delay);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherDelay = matcher;
            }

            return _matcherDelay;
        }
    }
}

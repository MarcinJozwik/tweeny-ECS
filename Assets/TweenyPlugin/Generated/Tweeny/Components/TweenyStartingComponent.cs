//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    static readonly TweenyPlugin.Tweening.ECS.Core.Start.Components.StartingComponent startingComponent = new TweenyPlugin.Tweening.ECS.Core.Start.Components.StartingComponent();

    public bool isStarting {
        get { return HasComponent(TweenyComponentsLookup.Starting); }
        set {
            if (value != isStarting) {
                var index = TweenyComponentsLookup.Starting;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : startingComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<TweenyEntity> _matcherStarting;

    public static Entitas.IMatcher<TweenyEntity> Starting {
        get {
            if (_matcherStarting == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Starting);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherStarting = matcher;
            }

            return _matcherStarting;
        }
    }
}

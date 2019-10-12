//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    static readonly TweenyPlugin.Tweening.ECS.Core.Finish.Components.FinishingComponent finishingComponent = new TweenyPlugin.Tweening.ECS.Core.Finish.Components.FinishingComponent();

    public bool isFinishing {
        get { return HasComponent(TweenyComponentsLookup.Finishing); }
        set {
            if (value != isFinishing) {
                var index = TweenyComponentsLookup.Finishing;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : finishingComponent;

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

    static Entitas.IMatcher<TweenyEntity> _matcherFinishing;

    public static Entitas.IMatcher<TweenyEntity> Finishing {
        get {
            if (_matcherFinishing == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Finishing);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherFinishing = matcher;
            }

            return _matcherFinishing;
        }
    }
}
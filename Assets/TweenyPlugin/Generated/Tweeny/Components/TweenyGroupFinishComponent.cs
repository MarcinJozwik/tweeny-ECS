//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    static readonly TweenyPlugin.Tweening.ECS.Core.Timeline.Components.GroupFinishComponent groupFinishComponent = new TweenyPlugin.Tweening.ECS.Core.Timeline.Components.GroupFinishComponent();

    public bool isGroupFinish {
        get { return HasComponent(TweenyComponentsLookup.GroupFinish); }
        set {
            if (value != isGroupFinish) {
                var index = TweenyComponentsLookup.GroupFinish;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : groupFinishComponent;

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

    static Entitas.IMatcher<TweenyEntity> _matcherGroupFinish;

    public static Entitas.IMatcher<TweenyEntity> GroupFinish {
        get {
            if (_matcherGroupFinish == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.GroupFinish);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherGroupFinish = matcher;
            }

            return _matcherGroupFinish;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    static readonly TweenyPlugin.Tweening.ECS.Sync.Components.FieldOfViewComponent fieldOfViewComponent = new TweenyPlugin.Tweening.ECS.Sync.Components.FieldOfViewComponent();

    public bool isFieldOfView {
        get { return HasComponent(TweenyComponentsLookup.FieldOfView); }
        set {
            if (value != isFieldOfView) {
                var index = TweenyComponentsLookup.FieldOfView;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : fieldOfViewComponent;

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

    static Entitas.IMatcher<TweenyEntity> _matcherFieldOfView;

    public static Entitas.IMatcher<TweenyEntity> FieldOfView {
        get {
            if (_matcherFieldOfView == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.FieldOfView);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherFieldOfView = matcher;
            }

            return _matcherFieldOfView;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    static readonly TweenyPlugin.Tweening.ECS.Sync.Components.MoveComponent moveComponent = new TweenyPlugin.Tweening.ECS.Sync.Components.MoveComponent();

    public bool isMove {
        get { return HasComponent(TweenyComponentsLookup.Move); }
        set {
            if (value != isMove) {
                var index = TweenyComponentsLookup.Move;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : moveComponent;

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

    static Entitas.IMatcher<TweenyEntity> _matcherMove;

    public static Entitas.IMatcher<TweenyEntity> Move {
        get {
            if (_matcherMove == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Move);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherMove = matcher;
            }

            return _matcherMove;
        }
    }
}

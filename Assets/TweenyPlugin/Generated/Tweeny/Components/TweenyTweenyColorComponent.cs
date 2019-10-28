//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public TweenyColorComponent tweenyColor { get { return (TweenyColorComponent)GetComponent(TweenyComponentsLookup.TweenyColor); } }
    public bool hasTweenyColor { get { return HasComponent(TweenyComponentsLookup.TweenyColor); } }

    public void AddTweenyColor(TweenyPlugin.Utilities.TweenyColor newTweenyColor) {
        var index = TweenyComponentsLookup.TweenyColor;
        var component = (TweenyColorComponent)CreateComponent(index, typeof(TweenyColorComponent));
        component.TweenyColor = newTweenyColor;
        AddComponent(index, component);
    }

    public void ReplaceTweenyColor(TweenyPlugin.Utilities.TweenyColor newTweenyColor) {
        var index = TweenyComponentsLookup.TweenyColor;
        var component = (TweenyColorComponent)CreateComponent(index, typeof(TweenyColorComponent));
        component.TweenyColor = newTweenyColor;
        ReplaceComponent(index, component);
    }

    public void RemoveTweenyColor() {
        RemoveComponent(TweenyComponentsLookup.TweenyColor);
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

    static Entitas.IMatcher<TweenyEntity> _matcherTweenyColor;

    public static Entitas.IMatcher<TweenyEntity> TweenyColor {
        get {
            if (_matcherTweenyColor == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.TweenyColor);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherTweenyColor = matcher;
            }

            return _matcherTweenyColor;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public TrailRendererComponent trailRenderer { get { return (TrailRendererComponent)GetComponent(TweenyComponentsLookup.TrailRenderer); } }
    public bool hasTrailRenderer { get { return HasComponent(TweenyComponentsLookup.TrailRenderer); } }

    public void AddTrailRenderer(UnityEngine.TrailRenderer newTrailRenderer) {
        var index = TweenyComponentsLookup.TrailRenderer;
        var component = (TrailRendererComponent)CreateComponent(index, typeof(TrailRendererComponent));
        component.TrailRenderer = newTrailRenderer;
        AddComponent(index, component);
    }

    public void ReplaceTrailRenderer(UnityEngine.TrailRenderer newTrailRenderer) {
        var index = TweenyComponentsLookup.TrailRenderer;
        var component = (TrailRendererComponent)CreateComponent(index, typeof(TrailRendererComponent));
        component.TrailRenderer = newTrailRenderer;
        ReplaceComponent(index, component);
    }

    public void RemoveTrailRenderer() {
        RemoveComponent(TweenyComponentsLookup.TrailRenderer);
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

    static Entitas.IMatcher<TweenyEntity> _matcherTrailRenderer;

    public static Entitas.IMatcher<TweenyEntity> TrailRenderer {
        get {
            if (_matcherTrailRenderer == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.TrailRenderer);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherTrailRenderer = matcher;
            }

            return _matcherTrailRenderer;
        }
    }
}

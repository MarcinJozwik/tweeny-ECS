//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public TweenyPlugin.Tweening.ECS.Core.Start.Components.ProgressComponent progress { get { return (TweenyPlugin.Tweening.ECS.Core.Start.Components.ProgressComponent)GetComponent(TweenyComponentsLookup.Progress); } }
    public bool hasProgress { get { return HasComponent(TweenyComponentsLookup.Progress); } }

    public void AddProgress(float newValue) {
        var index = TweenyComponentsLookup.Progress;
        var component = (TweenyPlugin.Tweening.ECS.Core.Start.Components.ProgressComponent)CreateComponent(index, typeof(TweenyPlugin.Tweening.ECS.Core.Start.Components.ProgressComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProgress(float newValue) {
        var index = TweenyComponentsLookup.Progress;
        var component = (TweenyPlugin.Tweening.ECS.Core.Start.Components.ProgressComponent)CreateComponent(index, typeof(TweenyPlugin.Tweening.ECS.Core.Start.Components.ProgressComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProgress() {
        RemoveComponent(TweenyComponentsLookup.Progress);
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

    static Entitas.IMatcher<TweenyEntity> _matcherProgress;

    public static Entitas.IMatcher<TweenyEntity> Progress {
        get {
            if (_matcherProgress == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Progress);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherProgress = matcher;
            }

            return _matcherProgress;
        }
    }
}

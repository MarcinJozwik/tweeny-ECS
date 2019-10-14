//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public Vector3Component vector3 { get { return (Vector3Component)GetComponent(TweenyComponentsLookup.Vector3); } }
    public bool hasVector3 { get { return HasComponent(TweenyComponentsLookup.Vector3); } }

    public void AddVector3(TweenyPlugin.Utilities.TweenyVector3 newValue, UnityEngine.Vector3 newStartValue, UnityEngine.Vector3 newEndValue) {
        var index = TweenyComponentsLookup.Vector3;
        var component = (Vector3Component)CreateComponent(index, typeof(Vector3Component));
        component.Value = newValue;
        component.StartValue = newStartValue;
        component.EndValue = newEndValue;
        AddComponent(index, component);
    }

    public void ReplaceVector3(TweenyPlugin.Utilities.TweenyVector3 newValue, UnityEngine.Vector3 newStartValue, UnityEngine.Vector3 newEndValue) {
        var index = TweenyComponentsLookup.Vector3;
        var component = (Vector3Component)CreateComponent(index, typeof(Vector3Component));
        component.Value = newValue;
        component.StartValue = newStartValue;
        component.EndValue = newEndValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVector3() {
        RemoveComponent(TweenyComponentsLookup.Vector3);
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

    static Entitas.IMatcher<TweenyEntity> _matcherVector3;

    public static Entitas.IMatcher<TweenyEntity> Vector3 {
        get {
            if (_matcherVector3 == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Vector3);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherVector3 = matcher;
            }

            return _matcherVector3;
        }
    }
}

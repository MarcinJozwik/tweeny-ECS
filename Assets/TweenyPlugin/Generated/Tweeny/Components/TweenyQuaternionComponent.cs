//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TweenyEntity {

    public QuaternionComponent quaternion { get { return (QuaternionComponent)GetComponent(TweenyComponentsLookup.Quaternion); } }
    public bool hasQuaternion { get { return HasComponent(TweenyComponentsLookup.Quaternion); } }

    public void AddQuaternion(UnityEngine.Quaternion newCurrentValue, UnityEngine.Quaternion newStartValue, UnityEngine.Quaternion newEndValue) {
        var index = TweenyComponentsLookup.Quaternion;
        var component = (QuaternionComponent)CreateComponent(index, typeof(QuaternionComponent));
        component.CurrentValue = newCurrentValue;
        component.StartValue = newStartValue;
        component.EndValue = newEndValue;
        AddComponent(index, component);
    }

    public void ReplaceQuaternion(UnityEngine.Quaternion newCurrentValue, UnityEngine.Quaternion newStartValue, UnityEngine.Quaternion newEndValue) {
        var index = TweenyComponentsLookup.Quaternion;
        var component = (QuaternionComponent)CreateComponent(index, typeof(QuaternionComponent));
        component.CurrentValue = newCurrentValue;
        component.StartValue = newStartValue;
        component.EndValue = newEndValue;
        ReplaceComponent(index, component);
    }

    public void RemoveQuaternion() {
        RemoveComponent(TweenyComponentsLookup.Quaternion);
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

    static Entitas.IMatcher<TweenyEntity> _matcherQuaternion;

    public static Entitas.IMatcher<TweenyEntity> Quaternion {
        get {
            if (_matcherQuaternion == null) {
                var matcher = (Entitas.Matcher<TweenyEntity>)Entitas.Matcher<TweenyEntity>.AllOf(TweenyComponentsLookup.Quaternion);
                matcher.componentNames = TweenyComponentsLookup.componentNames;
                _matcherQuaternion = matcher;
            }

            return _matcherQuaternion;
        }
    }
}

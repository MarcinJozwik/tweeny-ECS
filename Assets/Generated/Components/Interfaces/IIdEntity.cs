//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IIdEntity {

    TweenyPlugin.TweenSystems.Index.Components.IdComponent id { get; }
    bool hasId { get; }

    void AddId(int newValue);
    void ReplaceId(int newValue);
    void RemoveId();
}

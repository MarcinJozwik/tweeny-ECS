//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TweenyMatcher {

    public static Entitas.IAllOfMatcher<TweenyEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<TweenyEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<TweenyEntity> AllOf(params Entitas.IMatcher<TweenyEntity>[] matchers) {
          return Entitas.Matcher<TweenyEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<TweenyEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<TweenyEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<TweenyEntity> AnyOf(params Entitas.IMatcher<TweenyEntity>[] matchers) {
          return Entitas.Matcher<TweenyEntity>.AnyOf(matchers);
    }
}
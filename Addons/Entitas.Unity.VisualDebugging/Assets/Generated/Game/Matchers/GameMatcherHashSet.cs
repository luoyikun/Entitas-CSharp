//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class GameMatcher {

    static IMatcher<GameEntity> _matcherHashSet;

    public static IMatcher<GameEntity> HashSet {
        get {
            if(_matcherHashSet == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.HashSet);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHashSet = matcher;
            }

            return _matcherHashSet;
        }
    }
}
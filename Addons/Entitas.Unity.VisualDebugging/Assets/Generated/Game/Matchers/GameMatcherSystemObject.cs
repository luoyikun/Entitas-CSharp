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

    static IMatcher<GameEntity> _matcherSystemObject;

    public static IMatcher<GameEntity> SystemObject {
        get {
            if(_matcherSystemObject == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.SystemObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSystemObject = matcher;
            }

            return _matcherSystemObject;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public FlagEntityEventListenerComponent flagEntityEventListener { get { return (FlagEntityEventListenerComponent)GetComponent(TestComponentsLookup.FlagEntityEventListener); } }
    public bool hasFlagEntityEventListener { get { return HasComponent(TestComponentsLookup.FlagEntityEventListener); } }

    public void AddFlagEntityEventListener(System.Collections.Generic.List<IFlagEntityEventListener> newValue) {
        var index = TestComponentsLookup.FlagEntityEventListener;
        var component = CreateComponent<FlagEntityEventListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFlagEntityEventListener(System.Collections.Generic.List<IFlagEntityEventListener> newValue) {
        var index = TestComponentsLookup.FlagEntityEventListener;
        var component = CreateComponent<FlagEntityEventListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFlagEntityEventListener() {
        RemoveComponent(TestComponentsLookup.FlagEntityEventListener);
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
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherFlagEntityEventListener;

    public static Entitas.IMatcher<TestEntity> FlagEntityEventListener {
        get {
            if (_matcherFlagEntityEventListener == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.FlagEntityEventListener);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherFlagEntityEventListener = matcher;
            }

            return _matcherFlagEntityEventListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public void AddFlagEntityEventListener(IFlagEntityEventListener value) {
        var listeners = hasFlagEntityEventListener
            ? flagEntityEventListener.value
            : new System.Collections.Generic.List<IFlagEntityEventListener>();
        listeners.Add(value);
        ReplaceFlagEntityEventListener(listeners);
    }

    public void RemoveFlagEntityEventListener(IFlagEntityEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = flagEntityEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveFlagEntityEventListener();
        } else {
            ReplaceFlagEntityEventListener(listeners);
        }
    }
}

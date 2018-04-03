//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public TestMultipleEventsStandardEventListenerComponent testMultipleEventsStandardEventListener { get { return (TestMultipleEventsStandardEventListenerComponent)GetComponent(TestComponentsLookup.TestMultipleEventsStandardEventListener); } }
    public bool hasTestMultipleEventsStandardEventListener { get { return HasComponent(TestComponentsLookup.TestMultipleEventsStandardEventListener); } }

    public void AddTestMultipleEventsStandardEventListener(System.Collections.Generic.List<ITestMultipleEventsStandardEventListener> newValue) {
        var index = TestComponentsLookup.TestMultipleEventsStandardEventListener;
        var component = CreateComponent<TestMultipleEventsStandardEventListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTestMultipleEventsStandardEventListener(System.Collections.Generic.List<ITestMultipleEventsStandardEventListener> newValue) {
        var index = TestComponentsLookup.TestMultipleEventsStandardEventListener;
        var component = CreateComponent<TestMultipleEventsStandardEventListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTestMultipleEventsStandardEventListener() {
        RemoveComponent(TestComponentsLookup.TestMultipleEventsStandardEventListener);
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

    static Entitas.IMatcher<TestEntity> _matcherTestMultipleEventsStandardEventListener;

    public static Entitas.IMatcher<TestEntity> TestMultipleEventsStandardEventListener {
        get {
            if (_matcherTestMultipleEventsStandardEventListener == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestMultipleEventsStandardEventListener);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherTestMultipleEventsStandardEventListener = matcher;
            }

            return _matcherTestMultipleEventsStandardEventListener;
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

    public void AddTestMultipleEventsStandardEventListener(ITestMultipleEventsStandardEventListener value) {
        var listeners = hasTestMultipleEventsStandardEventListener
            ? testMultipleEventsStandardEventListener.value
            : new System.Collections.Generic.List<ITestMultipleEventsStandardEventListener>();
        listeners.Add(value);
        ReplaceTestMultipleEventsStandardEventListener(listeners);
    }

    public void RemoveTestMultipleEventsStandardEventListener(ITestMultipleEventsStandardEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = testMultipleEventsStandardEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTestMultipleEventsStandardEventListener();
        } else {
            ReplaceTestMultipleEventsStandardEventListener(listeners);
        }
    }
}

﻿//HintName: MyApp.ContextInitialization.Initialize.ContextInitialization.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.ContextInitializationMethod
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::MyApp.Main;

namespace MyApp
{
public static partial class ContextInitialization
{
    public static partial void Initialize()
    {
        global::MyAppMainEventComponentIndex.Index = new ComponentIndex(0);
        global::MyAppMainFlagEventComponentIndex.Index = new ComponentIndex(1);
        global::MyAppMainMultipleFieldsComponentIndex.Index = new ComponentIndex(2);
        global::MyAppMainAnyEventAddedListenerComponentIndex.Index = new ComponentIndex(3);
        global::MyAppMainAnyEventRemovedListenerComponentIndex.Index = new ComponentIndex(4);
        global::MyAppMainAnyFlagEventAddedListenerComponentIndex.Index = new ComponentIndex(5);
        global::MyAppMainAnyFlagEventRemovedListenerComponentIndex.Index = new ComponentIndex(6);
        global::MyAppMainEventAddedListenerComponentIndex.Index = new ComponentIndex(7);
        global::MyAppMainEventRemovedListenerComponentIndex.Index = new ComponentIndex(8);
        global::MyAppMainFlagEventAddedListenerComponentIndex.Index = new ComponentIndex(9);
        global::MyAppMainFlagEventRemovedListenerComponentIndex.Index = new ComponentIndex(10);
        global::MyFeature.MyAppMainAnotherNamespacedComponentIndex.Index = new ComponentIndex(11);
        global::MyFeature.MyAppMainContextFromDifferentAssemblyNamespacedComponentIndex.Index = new ComponentIndex(12);
        global::MyFeature.MyAppMainDuplicatedContextsNamespacedComponentIndex.Index = new ComponentIndex(13);
        global::MyFeature.MyAppMainEventNamespacedComponentIndex.Index = new ComponentIndex(14);
        global::MyFeature.MyAppMainFlagEventNamespacedComponentIndex.Index = new ComponentIndex(15);
        global::MyFeature.MyAppMainMultipleFieldsNamespacedComponentIndex.Index = new ComponentIndex(16);
        global::MyFeature.MyAppMainMultiplePropertiesNamespacedComponentIndex.Index = new ComponentIndex(17);
        global::MyFeature.MyAppMainAnyEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(18);
        global::MyFeature.MyAppMainAnyEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(19);
        global::MyFeature.MyAppMainAnyFlagEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(20);
        global::MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(21);
        global::MyFeature.MyAppMainEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(22);
        global::MyFeature.MyAppMainEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(23);
        global::MyFeature.MyAppMainFlagEventNamespacedAddedListenerComponentIndex.Index = new ComponentIndex(24);
        global::MyFeature.MyAppMainFlagEventNamespacedRemovedListenerComponentIndex.Index = new ComponentIndex(25);
        global::MyFeature.MyAppMainNonPublicComponentIndex.Index = new ComponentIndex(26);
        global::MyFeature.MyAppMainNoValidFieldsNamespacedComponentIndex.Index = new ComponentIndex(27);
        global::MyFeature.MyAppMainOneFieldNamespacedComponentIndex.Index = new ComponentIndex(28);
        global::MyFeature.MyAppMainReservedKeywordFieldsNamespacedComponentIndex.Index = new ComponentIndex(29);
        global::MyFeature.MyAppMainSomeNamespacedComponentIndex.Index = new ComponentIndex(30);
        global::MyFeature.MyAppMainSomeNamespacedComponentIndex.Index = new ComponentIndex(31);
        global::MyFeature.MyAppMainUniqueNamespacedComponentIndex.Index = new ComponentIndex(32);
        global::MyFeature.MyAppMainUniqueOneFieldNamespacedComponentIndex.Index = new ComponentIndex(33);
        global::MyOtherFeature.MyAppMainCollisionComponentIndex.Index = new ComponentIndex(34);
        global::MyOtherFeature.MyAppMainHealthComponentIndex.Index = new ComponentIndex(35);
        global::MyOtherFeature.MyAppMainCollisionAddedListenerComponentIndex.Index = new ComponentIndex(36);
        global::MyAppMainOneFieldComponentIndex.Index = new ComponentIndex(37);
        global::MyAppMainSomeComponentIndex.Index = new ComponentIndex(38);

        global::MyApp.MainContext.ComponentNames = new string[]
        {
            "Event",
            "FlagEvent",
            "MultipleFields",
            "MyAppMainAnyEventAddedListener",
            "MyAppMainAnyEventRemovedListener",
            "MyAppMainAnyFlagEventAddedListener",
            "MyAppMainAnyFlagEventRemovedListener",
            "MyAppMainEventAddedListener",
            "MyAppMainEventRemovedListener",
            "MyAppMainFlagEventAddedListener",
            "MyAppMainFlagEventRemovedListener",
            "MyFeature.AnotherNamespaced",
            "MyFeature.ContextFromDifferentAssemblyNamespaced",
            "MyFeature.DuplicatedContextsNamespaced",
            "MyFeature.EventNamespaced",
            "MyFeature.FlagEventNamespaced",
            "MyFeature.MultipleFieldsNamespaced",
            "MyFeature.MultiplePropertiesNamespaced",
            "MyFeature.MyAppMainAnyEventNamespacedAddedListener",
            "MyFeature.MyAppMainAnyEventNamespacedRemovedListener",
            "MyFeature.MyAppMainAnyFlagEventNamespacedAddedListener",
            "MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListener",
            "MyFeature.MyAppMainEventNamespacedAddedListener",
            "MyFeature.MyAppMainEventNamespacedRemovedListener",
            "MyFeature.MyAppMainFlagEventNamespacedAddedListener",
            "MyFeature.MyAppMainFlagEventNamespacedRemovedListener",
            "MyFeature.NonPublic",
            "MyFeature.NoValidFieldsNamespaced",
            "MyFeature.OneFieldNamespaced",
            "MyFeature.ReservedKeywordFieldsNamespaced",
            "MyFeature.SomeNamespaced",
            "MyFeature.SomeNamespaced",
            "MyFeature.UniqueNamespaced",
            "MyFeature.UniqueOneFieldNamespaced",
            "MyOtherFeature.Collision",
            "MyOtherFeature.Health",
            "MyOtherFeature.MyAppLibraryCollisionAddedListener",
            "OneField",
            "Some"
        };

        global::MyApp.MainContext.ComponentTypes = new global::System.Type[]
        {
            typeof(global::EventComponent),
            typeof(global::FlagEventComponent),
            typeof(global::MultipleFieldsComponent),
            typeof(global::MyAppMainAnyEventAddedListenerComponent),
            typeof(global::MyAppMainAnyEventRemovedListenerComponent),
            typeof(global::MyAppMainAnyFlagEventAddedListenerComponent),
            typeof(global::MyAppMainAnyFlagEventRemovedListenerComponent),
            typeof(global::MyAppMainEventAddedListenerComponent),
            typeof(global::MyAppMainEventRemovedListenerComponent),
            typeof(global::MyAppMainFlagEventAddedListenerComponent),
            typeof(global::MyAppMainFlagEventRemovedListenerComponent),
            typeof(global::MyFeature.AnotherNamespacedComponent),
            typeof(global::MyFeature.ContextFromDifferentAssemblyNamespacedComponent),
            typeof(global::MyFeature.DuplicatedContextsNamespacedComponent),
            typeof(global::MyFeature.EventNamespacedComponent),
            typeof(global::MyFeature.FlagEventNamespacedComponent),
            typeof(global::MyFeature.MultipleFieldsNamespacedComponent),
            typeof(global::MyFeature.MultiplePropertiesNamespacedComponent),
            typeof(global::MyFeature.MyAppMainAnyEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainAnyEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.MyAppMainAnyFlagEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.MyAppMainEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.MyAppMainFlagEventNamespacedAddedListenerComponent),
            typeof(global::MyFeature.MyAppMainFlagEventNamespacedRemovedListenerComponent),
            typeof(global::MyFeature.NonPublicComponent),
            typeof(global::MyFeature.NoValidFieldsNamespacedComponent),
            typeof(global::MyFeature.OneFieldNamespacedComponent),
            typeof(global::MyFeature.ReservedKeywordFieldsNamespacedComponent),
            typeof(global::MyFeature.SomeNamespacedComponent),
            typeof(global::MyFeature.SomeNamespacedComponent),
            typeof(global::MyFeature.UniqueNamespacedComponent),
            typeof(global::MyFeature.UniqueOneFieldNamespacedComponent),
            typeof(global::MyOtherFeature.CollisionComponent),
            typeof(global::MyOtherFeature.HealthComponent),
            typeof(global::MyOtherFeature.MyAppLibraryCollisionAddedListenerComponent),
            typeof(global::OneFieldComponent),
            typeof(global::SomeComponent)
        };
    }
}
}
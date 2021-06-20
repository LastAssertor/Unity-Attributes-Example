using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace UnityAttributesExample {

    public class ExcludeFromObjectFactoryExampleEditor {

        [@MenuItem("GameObject/Unity-Attributes-Example/ExcludeFromObjectFactoryExample/AddComponent_ExcludeFromObjectFactory===>Successed", false, 20)]
        static void AddComponent_ExcludeFromObjectFactory_Successed() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent<ExcludeFromObjectFactoryExample>();
            }
        }

        [@MenuItem("GameObject/Unity-Attributes-Example/ExcludeFromObjectFactoryExample/AddComponent_ExcludeFromObjectFactory(With Preset)===>Failed", false, 21)]
        static void AddComponentWithPreset_ExcludeFromObjectFactory_Failed() {
            if (Selection.activeGameObject != null) {
                ObjectFactory.AddComponent<ExcludeFromObjectFactoryExample>(Selection.activeGameObject);
            }
        }

        [@MenuItem("GameObject/Unity-Attributes-Example/ExcludeFromObjectFactoryExample/AddComponent===>Successed", false, 22)]
        static void AddComponent_Successed() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent<ObjectFactoryExample>();
            }
        }

        [@MenuItem("GameObject/Unity-Attributes-Example/ExcludeFromObjectFactoryExample/AddComponent(With Preset)===>Successed", false, 23)]
        static void AddComponentWithPreset_Successed() {

            /// <summary>
            /// https://sniperindia.com/Promotions/2019/10/17/unity-reseller-in-hyderabad-3/
            /// </summary>

            if (Selection.activeGameObject != null) {
                ObjectFactory.AddComponent<ObjectFactoryExample>(Selection.activeGameObject);
            }
        }

    }

}

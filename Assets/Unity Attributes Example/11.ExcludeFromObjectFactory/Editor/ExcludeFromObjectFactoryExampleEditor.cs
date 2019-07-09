using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace LGamekit {

    public class ExcludeFromObjectFactoryExampleEditor {

        [@MenuItem("GameObject/Exclude From ObjectFactory Example", false, 20)]
        static void AddDefaultComponentEditor() {
            if (Selection.activeGameObject != null) {
                ObjectFactory.AddComponent<ExcludeFromObjectFactoryExample>(Selection.activeGameObject);
            }
        }

    }

}

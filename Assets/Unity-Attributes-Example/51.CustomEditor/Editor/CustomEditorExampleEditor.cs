using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace UnityAttributesExample {

    [CustomEditor(typeof(CustomEditorExample), true)]
    public class CustomEditorExampleEditor : Editor {

        public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            if (GUILayout.Button("A button")) {

            }

        }

    }

}

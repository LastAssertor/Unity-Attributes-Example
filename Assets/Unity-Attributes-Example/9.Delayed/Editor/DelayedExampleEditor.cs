using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace UnityAttributesExample {

    [CustomEditor(typeof(DelayedExample))]
    public class DelayedExampleEditor : Editor {

        public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            DelayedExample example = target as DelayedExample;

            GUILayout.Label("The new int value is " + example.intValue);
            GUILayout.Label("The new float value is " + example.floatValue);
            GUILayout.Label("The new string value is '" + example.stringValue + "'");

            GUILayout.Box("" +
                "Attribute used to make a float, int, or string variable in a script be delayed. " +
                "When this attribute is used, the float, int, or text field will not return a new value " +
                "until the user has pressed enter or focus is moved away from the field.");
        }

    }

}

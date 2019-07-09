using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace LGamekit {

    [CustomPropertyDrawer(typeof(TabEnumAttribute))]
    public class TabEnumAttributeDrawer : PropertyDrawer {

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            GUI.Label(new Rect(position) {
                width = 50f
            }, label);
            property.enumValueIndex = GUI.Toolbar(new Rect(position) {
                x = position.x + 52f,
                width = position.width - 54f
            }, property.enumValueIndex, property.enumDisplayNames);
        }

    }

}

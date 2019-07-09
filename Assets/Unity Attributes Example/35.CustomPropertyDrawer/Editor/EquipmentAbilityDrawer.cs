using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace LGamekit {

    [CustomPropertyDrawer(typeof(EquipmentAbility))]
    public class EquipmentAbilityDrawer : PropertyDrawer {

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var typeRect = new Rect(position.x, position.y, position.width / 2, position.height);
            var amountRect = new Rect(position.x + position.width / 2 + 10, position.y, position.width / 2 - 10, position.height);

            EditorGUI.PropertyField(typeRect, property.FindPropertyRelative("type"), GUIContent.none);
            EditorGUI.PropertyField(amountRect, property.FindPropertyRelative("amount"), GUIContent.none);

            EditorGUI.indentLevel = indent;

            EditorGUI.EndProperty();

        }

    }

}


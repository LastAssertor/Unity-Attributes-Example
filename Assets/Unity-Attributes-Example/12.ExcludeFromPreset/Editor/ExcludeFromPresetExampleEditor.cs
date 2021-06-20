using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEditor.Presets;

namespace UnityAttributesExample {

    public class ExcludeFromPresetExampleEditor {

        [@MenuItem("Assets/Unity-Attributes-Example/Exclude From Preset Example/Generate Preset", false, 5022)]
        static void CreatePreset() {
            if (Selection.activeObject != null && Selection.activeObject.GetType() == typeof(ExcludeFromPresetExample)) {
                var preset = new Preset(Selection.activeObject);
                var path = AssetDatabase.GetAssetPath(Selection.activeObject);
                var ext = System.IO.Path.GetExtension(path);
                AssetDatabase.CreateAsset(preset, path.Replace(ext, ".preset"));
            } else {
                Debug.LogWarning("Please select an 'ExcludeFromPresetExample' type asset.");
            }
        }

    }

}

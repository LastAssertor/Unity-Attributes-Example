using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;


namespace UnityAttributesExample {

    [FilePath("Assets/Unity-Attributes-Example/50.FilePath/Editor/FilePathExample.txt", FilePathAttribute.Location.ProjectFolder)]
    public class MySingleton : ScriptableSingleton<MySingleton> {

        [SerializeField]
        float m_Number = 42;

        [SerializeField]
        List<string> m_Strings = new List<string>();

        public void Modify() {
            m_Number *= 2;
            m_Strings.Add("Foo" + m_Number);

            Save(true);
            Debug.Log("Saved to: " + GetFilePath());
            AssetDatabase.Refresh();
        }

        public void Log() {
            Debug.Log("MySingleton state: " + JsonUtility.ToJson(this, true));
        }

    }

    static class MySingletonMenuItems {
        [MenuItem("Unity-Attributes-Example/FilePathExample/SingletonTest/Log")]
        static void LogMySingletonState() {
            MySingleton.instance.Log();
        }

        [MenuItem("Unity-Attributes-Example/FilePathExample/SingletonTest/Modify")]
        static void ModifyMySingletonState() {
            MySingleton.instance.Modify();
        }
    }
}

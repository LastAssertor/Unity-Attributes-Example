using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace UnityAttributesExample {

    /// <summary>
    /// https://docs.unity3d.com/ScriptReference/InitializeOnLoadAttribute.html
    ///
    /// Allows you to initialize an Editor class when Unity loads,
    /// and when your scripts are recompiled.
    /// Static constructors with this attribute are called
    /// when scripts in the project are recompiled (also known as a Domain Reload).
    /// when Unity first loads your project,
    /// but also when Unity detects modifications to scripts
    /// (depending on your Auto Refresh preferences),
    /// and when you enter Play Mode (depending on your Play Mode configuration).
    /// </summary>

    // Running Editor Script Code on Launch

    [InitializeOnLoad]
    public class InitializeOnLoadExample {

        static InitializeOnLoadExample() {

            /// https://docs.unity3d.com/Manual/RunningEditorCodeOnLaunch.html

            //Debug.Log("Up and running");

            // editor frame update

            //EditorApplication.update += Update;

        }

        //static void Update() {
        //    Debug.Log("Updating");
        //}

        [InitializeOnLoadMethod]
        static void OnProjectLoadedInEditor() {

            /// https://docs.unity3d.com/ScriptReference/InitializeOnLoadMethodAttribute.html

            //Debug.Log("Project loaded in Unity Editor");
        }

    }

}

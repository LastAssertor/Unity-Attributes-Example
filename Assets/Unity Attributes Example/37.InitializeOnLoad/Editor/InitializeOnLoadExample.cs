using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace LGamekit {

    // Running Editor Script Code on Launch

    [InitializeOnLoad]
    public class InitializeOnLoadExample {

        static InitializeOnLoadExample() {
            Debug.Log("Up and running");

            // editor frame update

            //EditorApplication.update += Update;

        }

        //static void Update() {
        //    Debug.Log("Updating");
        //}

        [InitializeOnLoadMethod]
        static void OnProjectLoadedInEditor() {
            Debug.Log("Project loaded in Unity Editor");
        }
    }

}

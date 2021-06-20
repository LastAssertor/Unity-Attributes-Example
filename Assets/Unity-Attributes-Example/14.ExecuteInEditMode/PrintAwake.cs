using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    /// <summary>
    /// https://docs.unity3d.com/ScriptReference/ExecuteInEditMode.html
    /// </summary>

    // The PrintAwake script is placed on a GameObject.  The Awake function is usually
    // called when the GameObject is started at runtime.  Due to the ExecuteInEditMode
    // attribute, the script is also called by the Editor.  The Awake() function will be called,
    // for example, when the Scene is changed to a
    // different Scene in the Project window.
    // The Update() function is called, for example, when the GameObject transform
    // position is changed in the Editor.

    [ExecuteInEditMode]
    public class PrintAwake : MonoBehaviour {
        void Awake() {
            Debug.Log("Editor causes this Awake");
        }

        void Update() {
            Debug.Log("Editor causes this Update");
        }
    }

}

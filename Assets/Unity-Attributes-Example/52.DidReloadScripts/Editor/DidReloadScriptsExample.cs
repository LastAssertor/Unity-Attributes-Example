using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEditor.Callbacks;

namespace UnityAttributesExample {

    public class DidReloadScriptsExample {
        [DidReloadScripts]
        static void AfterReloadedScripts() {
            //Debug.LogWarning("AfterReloadedScripts");
        }
    }

}


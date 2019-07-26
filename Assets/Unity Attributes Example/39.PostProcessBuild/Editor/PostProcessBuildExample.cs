using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEditor.Callbacks;

namespace LGamekit {

    public class PostProcessBuildExample {

        // Add this attribute to a method to get a notification just after building the player.

        // PostProcessBuildAttribute has an option to provide an order index in the callback, starting at 0.
        // This is useful if you have more than one PostProcessBuildAttribute callback,
        // and you would like them to be called in a certain order. Callbacks are called in order, starting at zero.

        [PostProcessBuild(1)]
        public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {
            // after build
            Debug.Log(target + ":" + pathToBuiltProject);
        }
    }

}
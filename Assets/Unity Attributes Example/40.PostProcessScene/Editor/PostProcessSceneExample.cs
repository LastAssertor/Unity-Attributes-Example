using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEditor.Callbacks;

namespace LGamekit {

    public class PostProcessSceneExample {

        // Add this attribute to a method to get a notification just after building the Scene.

        // A method with this attribute will also get called when entering Playmode, when SceneManager.LoadScene is called.

        // PostProcessSceneAttribute has an option to provide an order index in the callback, starting at 0.
        // This is useful if you have more than one OnPostprocessScene callback,
        // and you would like them to be called in a certain order. Callbacks are called in order, starting at zero.

        [PostProcessScene(2)]
        static void OnPostprocessScene() {
            OnBeforeSceneLoaded();
        }

        static void OnBeforeSceneLoaded() {
            var scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            Debug.LogWarning("OnBeforeSceneLoaded ======> " + scene.name + ".unity");
        }

    }

}

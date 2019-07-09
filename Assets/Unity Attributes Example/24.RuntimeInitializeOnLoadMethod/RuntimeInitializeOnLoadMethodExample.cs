using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    class RuntimeInitializeOnLoadMethodExample {

        // Allow a runtime class method to be initialized when a game is loaded at runtime without action from the user.

        // Methods marked [RuntimeInitializeOnLoadMethod] are invoked after the game has been loaded.
        // This is after the Awake method has been invoked.

        // Note: The execution order of methods marked [RuntimeInitializeOnLoadMethod] is not guaranteed.

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void OnBeforeSceneLoad() {
            Debug.LogWarning("OnBeforeSceneLoad");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static void OnAfterSceneLoad() {
            Debug.LogWarning("OnAfterSceneLoad");
        }

        //[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        //static void OnBeforeSplashScreen() {
        //    Debug.LogWarning("OnBeforeSplashScreen");
        //}

        //[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        //static void OnAfterAssembliesLoaded() {
        //    Debug.LogWarning("OnAfterAssembliesLoaded");
        //}

        //[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        //static void OnSubsystemRegistration() {
        //    Debug.LogWarning("OnSubsystemRegistration");
        //}
    }

}

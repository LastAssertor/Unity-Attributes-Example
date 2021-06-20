using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    /// ！！！！提示：取消下面的注释后，运行测试！！！！！

    /*

    class RuntimeInitializeOnLoadMethodExample {

        // Allow a runtime class method to be initialized when a game is loaded at runtime without action from the user.

        // Methods marked [RuntimeInitializeOnLoadMethod] are invoked after the game has been loaded.
        // This is after the Awake method has been invoked.

        // Note: The execution order of methods marked [RuntimeInitializeOnLoadMethod] is not guaranteed.

        // Callback used for registration of subsystems
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void OnSubsystemRegistration() {
            Debug.Log("0.OnSubsystemRegistration");
        }

        // Callback when all assemblies are loaded and preloaded assets are initialized.
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        static void OnAfterAssembliesLoaded() {
            Debug.Log("1.OnAfterAssembliesLoaded");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        static void OnBeforeSplashScreen() {
            Debug.Log("2.Before the splash screen is shown.");
        }

        // 加载第一个场景时会被调用
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void OnBeforeSceneLoad() {
            Debug.Log("3.Before first Scene loaded");
        }

        // 等价于[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        [RuntimeInitializeOnLoadMethod]
        static void OnAfterSceneLoad1() {
            Debug.Log("4-1.After first Scene loaded");
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static void OnAfterSceneLoad2() {
            Debug.Log("4-2.After first Scene loaded");
        }

        [RuntimeInitializeOnLoadMethod]
        static void OnAfterSceneLoad3() {
            Debug.Log("4-3.After first Scene loaded");
        }

    }

    */

}

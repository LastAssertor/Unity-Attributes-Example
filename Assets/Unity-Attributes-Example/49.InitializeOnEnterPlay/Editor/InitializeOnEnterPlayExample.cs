using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

/// <summary>
/// https://docs.unity.cn/2021.2/Documentation/ScriptReference/InitializeOnEnterPlayModeAttribute.html
/// </summary>
/// 
namespace UnityAttributesExample {

    /// <summary>
    /// Reset static fields in Editor classes on Enter Play Mode without Domain Reload.
    /// </summary>

    public class MyAnotherClass {
        public static int s_MySimpleValue = 0;

        /// <summary>
        /// Allow an editor class method to be initialized when Unity enters Play Mode.
        /// </summary>
        /// <param name="options"></param>
        [InitializeOnEnterPlayMode]
        static void OnEnterPlaymodeInEditor(EnterPlayModeOptions options) {
            //Debug.Log("Entering PlayMode");

            if (options.HasFlag(EnterPlayModeOptions.DisableDomainReload))
                s_MySimpleValue = 0;
        }
    }

    /// <summary>
    /// Perform any other logic on Enter Play Mode.
    /// </summary>

    public class MyClass {
        public static int s_MyValue = 0;

        static void MyClassPlaymodeSetup() {
            s_MyValue = 1000;
            //...
        }

        [InitializeOnEnterPlayMode]
        static void OnEnterPlaymodeInEditor(EnterPlayModeOptions options) {
            //Debug.Log("Entering PlayMode");
            MyClassPlaymodeSetup();
        }
    }

}


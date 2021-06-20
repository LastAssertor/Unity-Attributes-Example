using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Declares an assembly to be compatible (API wise) with a specific Unity API.
// Used by internal tools to avoid processing the assembly in order to decide whether assemblies may be using old Unity API.

// checkOnlyUnityVersion	Must be set to true.

[assembly: UnityAPICompatibilityVersion("2019.1.1f1", true)]

namespace UnityAttributesExample {

    /// <summary>
    /// https://blog.csdn.net/akof1314/article/details/54141624
    /// https://blog.unity.com/technology/assemby-updater-faster-api-usage-detection
    /// https://support.unity.com/hc/en-us/articles/205931009-The-process-of-importing-DLL-s-between-Unity-4-and-Unity-5-is-slower-
    /// </summary>

    public class UnityAPICompatibilityVersionExample : MonoBehaviour {

    }

}

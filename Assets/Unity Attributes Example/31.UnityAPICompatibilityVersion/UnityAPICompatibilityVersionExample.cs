using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Declares an assembly to be compatible (API wise) with a specific Unity API.
// Used by internal tools to avoid processing the assembly in order to decide whether assemblies may be using old Unity API.

// checkOnlyUnityVersion	Must be set to true.

[assembly: UnityAPICompatibilityVersion("2019.1.1f1", true)]

namespace LGamekit {

    public class UnityAPICompatibilityVersionExample : MonoBehaviour {

    }

}

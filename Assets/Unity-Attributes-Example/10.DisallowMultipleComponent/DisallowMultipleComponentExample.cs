using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    // Prevents MonoBehaviour of same type (or subtype) to be added more than once to a GameObject.

    [DisallowMultipleComponent]
    public class DisallowMultipleComponentExample : MonoBehaviour {

    }

}

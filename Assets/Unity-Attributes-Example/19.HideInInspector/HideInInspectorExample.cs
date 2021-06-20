using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class HideInInspectorExample : MonoBehaviour {

        // Makes a variable not show up in the inspector but be serialized.

        [HideInInspector]
        public int p = 5;

    }

}

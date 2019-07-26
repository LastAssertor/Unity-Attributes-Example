using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class DelayedExample : MonoBehaviour {

        // Attribute used to make a float, int, or string variable in a script be delayed.
        // When this attribute is used, the float, int, or text field will not return a new value
        // until the user has pressed enter or focus is moved away from the field.

        [Delayed]
        public int intValue = 22;
        [Delayed]
        public float floatValue = 0.618f;
        [Delayed]
        public string stringValue = "test delayed attribute";

    }

}

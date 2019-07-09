using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class DelayedExample : MonoBehaviour {

        // Attribute used to make a float, int, or string variable in a script be delayed.
        // When this attribute is used, the float, int, or text field will not return a new value
        // until the user has pressed enter or focus is moved away from the field.

        [Delayed]
        public int intValue;
        [Delayed]
        public float floatValue;
        [Delayed]
        public string stringValue;

    }

}

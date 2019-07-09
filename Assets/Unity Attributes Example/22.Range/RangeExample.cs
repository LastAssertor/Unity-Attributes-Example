using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class RangeExample : MonoBehaviour {

        // Attribute used to make a float or int variable in a script be restricted to a specific range.

        // When this attribute is used, the float or int will be shown as a slider in the Inspector instead of the default number field.

        [Range(0, 100)]
        public int intValue;
        [Range(0, 1000f)]
        public float floatValue;

    }

}

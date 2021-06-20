using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class MultilineExample : MonoBehaviour {

        [Multiline(8)] // Attribute to make a string be edited with a multi-line textfield.
        public string value;

    }

}

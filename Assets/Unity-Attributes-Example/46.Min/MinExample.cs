using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class MinExample : MonoBehaviour {

        [Min(20)]
        public int intMin = 20;
        [Min(1.2f)]
        public float floatMin = 1.2f;

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public enum MyEnum {
        A,
        [InspectorName("B评分")]
        B,
        [InspectorName("C评分")]
        C,
    }


    public class InspectorNameExample : MonoBehaviour {

        public MyEnum myEnum;


    }

}
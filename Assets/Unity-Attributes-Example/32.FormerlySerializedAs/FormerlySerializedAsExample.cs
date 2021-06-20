using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Serialization;

namespace UnityAttributesExample {

    public class FormerlySerializedAsExample : MonoBehaviour {

        [FormerlySerializedAs("myValue")] // Use this attribute to rename a field without losing its serialized value.
        [SerializeField]
        string m_MyValue;

        public string myValue {
            get { return m_MyValue; }
            set { m_MyValue = value; }
        }

    }

}

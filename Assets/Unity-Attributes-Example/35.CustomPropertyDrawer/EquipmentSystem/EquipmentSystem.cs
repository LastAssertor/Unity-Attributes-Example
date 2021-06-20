using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class EquipmentSystem : MonoBehaviour {

        [Header("套装装备")]
        public List<EquipmentGroup> groups = new List<EquipmentGroup>();
        [Header("散装装备")]
        public List<Equipment> normals = new List<Equipment>();


    }

}

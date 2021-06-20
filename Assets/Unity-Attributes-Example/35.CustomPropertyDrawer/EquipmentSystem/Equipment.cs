using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    [System.Serializable]
    public class Equipment {

        public int id;

        [TabEnum]
        public EquipmentType type;
        public List<EquipmentAbility> ups = new List<EquipmentAbility>();
        public List<EquipmentAbility> downs = new List<EquipmentAbility>();
    }

}

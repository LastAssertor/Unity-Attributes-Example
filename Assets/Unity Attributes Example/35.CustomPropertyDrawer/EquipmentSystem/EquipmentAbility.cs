using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    [System.Serializable]
    public class EquipmentAbility {
        [TabEnum]
        public EquipmentAbilityType type;
        public int amount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    [System.Serializable]
    public class EquipmentGroup {
        [Header("套装效果")]
        public List<EquipmentEffect> effects = new List<EquipmentEffect>();
        [Header("套装部件")]
        public List<Equipment> parts = new List<Equipment>();
    }


}

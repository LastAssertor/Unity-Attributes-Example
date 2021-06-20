using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    [System.Serializable]
    public class EquipmentEffect {
        [Header("需要达到指定数量的套装猜能获得效果")]
        public int require = 3;
        [Header("增益效果")]
        public List<EquipmentAbility> ups = new List<EquipmentAbility>();
        [Header("减益效果")]
        public List<EquipmentAbility> downs = new List<EquipmentAbility>();
    }

}

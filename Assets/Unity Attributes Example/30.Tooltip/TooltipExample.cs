using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class TooltipExample : MonoBehaviour {

        [Tooltip("Health value between 0 and 100.")]
        [Range(0, 100)]
        public int health = 0;

    }

}

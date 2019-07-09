using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class SpaceExample : MonoBehaviour {

        public int health = 0;
        public int maxHealth = 100;

        [Space(10)] // 10 pixels of spacing here.

        public int shield = 0;
        public int maxShield = 0;

    }

}

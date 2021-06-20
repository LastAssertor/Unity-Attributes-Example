using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class HeaderExample : MonoBehaviour {

        // Use this PropertyAttribute to add a header above some fields in the Inspector.

        // The header is done using a DecoratorDrawer.

        [Header("Health Settings")]
        public int health = 0;
        public int maxHealth = 100;

        [Header("Shield Settings")]
        public int shield = 0;
        public int maxShield = 0;

    }

}

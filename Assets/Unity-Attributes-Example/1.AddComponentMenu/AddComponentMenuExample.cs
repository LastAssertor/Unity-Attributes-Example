using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    // The AddComponentMenu attribute allows you to place a script anywhere in the "Component" menu,
    // instead of just the "Component->Scripts" menu.
    // You use this to organize the Component menu better,
    // this way improving workflow when adding scripts.
    //
    // Important notice: You need to restart.

    [AddComponentMenu("Unity-Atrributes-Example/Add Component Menu Example")]
    public class AddComponentMenuExample : MonoBehaviour {

    }

}

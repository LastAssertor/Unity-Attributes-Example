using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    // Add this attribute to a script class to mark its GameObject as a selection base object for Scene View picking.

    // In the Unity Scene View, when clicking to select objects,
    // Unity will try to figure out the best object to select for you.
    // If you click on an object that is part of a Prefab, the root of the Prefab is selected,
    // because a Prefab root is treated as a selection base. You can make other objects be treated as selection base too.
    // You need to create a script class with the SelectionBase attribute, and then you need to add that script to the GameObject.

    [SelectionBase]
    public class SelectionBaseExample : MonoBehaviour {


    }

}

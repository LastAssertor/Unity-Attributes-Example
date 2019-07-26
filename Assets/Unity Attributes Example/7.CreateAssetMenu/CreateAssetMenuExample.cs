using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    // Mark a ScriptableObject-derived type to be automatically listed in the Assets/Create submenu,
    // so that instances of the type can be easily created and stored in the project as ".asset" files.

    [CreateAssetMenu(fileName = "CreateAssetMenuExample.asset", menuName = "UnityAttributeExample/CreateAssetMenuExample", order = -7020)]
    public class CreateAssetMenuExample : ScriptableObject {

        public int myInt = 222;

        public string myString = "this is a scriptable object asset";

    }

}

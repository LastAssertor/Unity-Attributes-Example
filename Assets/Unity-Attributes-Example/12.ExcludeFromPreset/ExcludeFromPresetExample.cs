using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    // Add ExcludeFromPreset attribute to a class to prevent creating a Preset from the instances of the class.

    [ExcludeFromPreset]
    [CreateAssetMenu(fileName = "ExcludeFromPresetExample.asset", menuName = "Unity-Attributes-Example/Exclude From Preset Example", order = 7021)]
    public class ExcludeFromPresetExample : ScriptableObject {

    }

}

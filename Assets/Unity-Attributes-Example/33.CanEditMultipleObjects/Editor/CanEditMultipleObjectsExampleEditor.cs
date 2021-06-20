using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace UnityAttributesExample {

    [CanEditMultipleObjects] // Attribute used to make a custom editor support multi-object editing.
    [CustomEditor(typeof(CanEditMultipleObjectsExample))] // Tells an Editor class which run-time type it's an editor for.
    public class CanEditMultipleObjectsExampleEditor : Editor {


    }

}

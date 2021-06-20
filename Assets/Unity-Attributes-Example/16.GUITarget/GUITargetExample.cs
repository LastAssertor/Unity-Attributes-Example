using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class GUITargetExample : MonoBehaviour {

        // GUITarget attribute allows to control for which display the OnGUI is called.

        [GUITarget(1, 2)]
        void OnGUI() {
            var color = GUI.color;
            GUI.color = Color.red;
            GUILayout.Space(30f);
            GUILayout.Label("     This information is visible on 'Display 2' and 'Display 3' only.");
            GUI.color = color;
        }

    }

}

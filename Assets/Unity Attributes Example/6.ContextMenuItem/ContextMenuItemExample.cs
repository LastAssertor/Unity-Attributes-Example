using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class ContextMenuItemExample : MonoBehaviour {

        const int DEFAULT_VALUE = 100;

        // Use this attribute to add a context menu to a field that calls a named method.

        [ContextMenuItem("Log", "LogValue", order = -1)]
        [ContextMenuItem("Reset", "ResetValue")]
        public int value = DEFAULT_VALUE;

        void LogValue() {
            Debug.LogWarning(value);
        }

        void ResetValue() {
            value = DEFAULT_VALUE;
        }

    }

}

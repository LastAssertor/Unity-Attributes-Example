using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public static class ApplicationUtility {

        public static void Quit() {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

    }

}

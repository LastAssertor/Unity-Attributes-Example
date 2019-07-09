using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

namespace LGamekit {

    public class MyScriptGizmoDrawer {

        [DrawGizmo(GizmoType.Selected | GizmoType.Active)]
        static void DrawGizmoForMyScript(MyScript scr, GizmoType gizmoType) {
            Vector3 position = scr.transform.position;

            if (Vector3.Distance(position, Camera.current.transform.position) > 10f)
                Gizmos.DrawIcon(position, "MyScript Gizmo.png", true);
        }
    }

}

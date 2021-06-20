using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Reflection;

namespace UnityAttributesExample {

    public static class AssemblyExtensions {

        public static bool IsEditorAssembly(this Assembly assembly) {
            return Attribute.IsDefined(assembly, typeof(UnityEngine.AssemblyIsEditorAssembly));
        }

    }

}

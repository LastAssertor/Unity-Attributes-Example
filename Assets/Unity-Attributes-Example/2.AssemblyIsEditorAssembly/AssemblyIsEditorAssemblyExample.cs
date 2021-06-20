using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Assembly level attribute. Any classes in an assembly with this attribute will be considered to be Editor Classes.

// 这个程序集下的任何类都会被引擎认为是编辑器类，
// 例如：在这个程序集里，继承MonoBehaviour的脚本都不能被挂载到GameObject上

[assembly: AssemblyIsEditorAssembly] // Add 'AssemblyIsEditorAssembly' attribute to this assembly.

namespace UnityAttributesExample {

    public class AssemblyIsEditorAssemblyExample : MonoBehaviour {

    }

}


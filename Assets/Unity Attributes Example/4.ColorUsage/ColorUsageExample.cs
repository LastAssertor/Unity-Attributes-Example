using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class ColorUsageExample : MonoBehaviour {

        // Use this attribute on a Color to configure the Color Field and Color Picker
        // to show/hide the alpha value and whether to treat the color as a HDR color or as a normal LDR color.

        [ColorUsage(true, true)]
        public Color DHRColor;

    }

}

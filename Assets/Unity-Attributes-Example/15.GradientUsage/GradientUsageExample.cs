using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class GradientUsageExample : MonoBehaviour {

        // Attribute used to configure the usage of the GradientField and Gradient Editor for a gradient.

        // Use this attribute on a Gradient to configure the GradientField and Gradient Editor to treat the colors as HDR colors or as normal LDR colors.

        [GradientUsage(true)]
        public Gradient gradient;

    }

}

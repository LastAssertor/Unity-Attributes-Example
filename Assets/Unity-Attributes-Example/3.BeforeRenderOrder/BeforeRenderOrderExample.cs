using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class BeforeRenderOrderExample : MonoBehaviour {

        void Start() {

            // Application.onBeforeRender will reorder all registered events recievers and call them in order,
            // from lowest to highest, based on this attribute. No attribute represents an order of 0.

            Application.onBeforeRender += StepC;
            Application.onBeforeRender += StepB;
            Application.onBeforeRender += StepA;
        }

        // Use this BeforeRenderOrderAttribute when you need to specify a custom callback order for Application.onBeforeRender.

        [BeforeRenderOrder(1)]
        void StepA() {
            Debug.LogWarning("Do somethings on step A.");
        }

        [BeforeRenderOrder(2)]
        //[BeforeRenderOrder(4)]
        void StepB() {
            Debug.LogWarning("Do somethings on step B.");
        }

        [BeforeRenderOrder(3)]
        void StepC() {
            Debug.LogWarning("Do somethings on step C.");
        }

    }

}

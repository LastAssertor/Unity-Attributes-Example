using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEditor.Callbacks;

namespace LGamekit {

    public class OnOpenAssetExample {

        // Callback attribute for opening an asset in Unity (e.g the callback is fired when double clicking an asset in the Project Browser).

        // Adding this attribute to a static method will make the method be called when Unity is about to open an asset.
        // The method should have the following signature:

        // static bool OnOpenAsset(int instanceID, int line) 
        // Return true if you handled the opening of the asset or false if an external tool should open it.

        [OnOpenAsset(1)]
        public static bool step1(int instanceID, int line) {
            string name = EditorUtility.InstanceIDToObject(instanceID).name;
            Debug.Log("Open Asset step: 1 (" + name + ")");
            return false; // we did not handle the open
        }

        // OnOpenAssetAttribute has an option to provide an order index in the callback, starting at 0.
        // This is useful if you have more than one OnOpenAssetAttribute callback, and you would like them to be called in a certain order.
        // Callbacks are called in order, starting at zero.

        // step2 has an attribute with index 2, so will be called after step1
        [OnOpenAsset(2)]
        public static bool step2(int instanceID, int line) {
            Debug.Log("Open Asset step: 2 (" + instanceID + ")");
            return false; // we did not handle the open
        }
    }

}
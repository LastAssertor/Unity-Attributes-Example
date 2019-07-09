using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    // ExecuteInEditMode attribute makes all instances of a script execute in Edit Mode.

    // This attribute is being phased out since it does not take Prefab Mode into account.
    // If a Prefab with a MonoBehaviour with this attribute on is edited in Prefab Mode,
    // and Play Mode is entered, the Editor will exit Prefab Mode to prevent accidental modifications to the Prefab caused by logic intended for Play Mode only.

    // To indicate that a MonoBehaviour correctly takes Prefab Mode into account and is safe to have open in Prefab Mode while in Play Mode,
    // the attribute ExecuteAlways can be used instead of the attribute here.

    [ExecuteInEditMode]
    public class ExecuteInEditModeExample : MonoBehaviour {


    }

}

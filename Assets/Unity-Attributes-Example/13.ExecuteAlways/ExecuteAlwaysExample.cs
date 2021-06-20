using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    [ExecuteAlways]
    public class ExecuteAlwaysExample : MonoBehaviour {

        /// <summary>
        /// https://docs.unity3d.com/ScriptReference/ExecuteAlways.html
        /// </summary>

        void Start() {

            if (Application.IsPlaying(gameObject)) {

                // Play logic

            } else {

                // Editor logic

            }
        }

        #region On an object which is not part of the playing world, the functions are not called constantly like they otherwise are.

        void Update() {
            if (Application.IsPlaying(gameObject)) {

                // Play logic

            } else {

                // - Update is only called when something in the Scene changed.

                // Editor logic

                //Debug.LogWarning("Editor Update()");
            }
        }

        void OnGUI() {
            if (Application.IsPlaying(gameObject)) {

                // Play logic

            } else {

                // - OnGUI is called when the Game view receives a non-editor-only Event that it does not use (e.g., EventType.ScrollWheel)
                // and does not forward to the Editor's keyboard shortcut system (e.g., EventType.KeyDown, EventType.KeyUp).
                // Events forwarded to the Game view are enqueued and are not guaranteed to be processed immediately.

                // Editor logic

            }

        }

        void OnRenderObject() {
            if (Application.IsPlaying(gameObject)) {

                // Play logic

            } else {

                // - OnRenderObject and the other rendering callback functions are called on every repaint of the Scene view or Game view.

                // Editor logic

            }
        }

        #endregion

    }

}

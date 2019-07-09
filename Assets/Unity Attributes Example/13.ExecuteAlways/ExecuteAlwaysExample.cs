using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    // ExecuteAlways attribute makes instances of a script always execute, both as part of Play Mode and when editing.

    // By default, MonoBehaviours are only executed in Play Mode and only if they are on GameObjects in the main stage containing the user Scenes.
    // They do not execute in Edit Mode, nor do they execute on objects edited in Prefab Mode,
    // even while in Play Mode. By adding this attribute,
    // any instance of the MonoBehaviour will have its callback functions executed at all times.

    // The [ExecuteAlways] attribute can be used when you want your script to perform certain things as part of Editor tooling,
    // which is not necessarily related to the Play logic that happens in buildt Players and in Play Mode.
    // Sometimes the Play functionality of such a script is identical to its Edit Mode functionality,
    // while other times they differ greatly.

    [ExecuteAlways]
    public class ExecuteAlwaysExample : MonoBehaviour {

        void Start() {

            // A MonoBehaviour using this attribute must ensure that they do not run Play logic
            // that incorrectly modifies the object while in Edit Mode, or if the object is not part of the playing world.
            // This can be done via Application.IsPlaying in which the script can pass in its own GameObject to check
            // if it's part of the playing world.

            // If a MonoBehaviour runs Play logic in Play Mode and fails to check if its GameObject is part of the playing world,
            // a Prefab being edited in Prefab Mode may incorrectly get modified and saved by logic intended only to be run as part of the game.

            // If your script makes use of static variables or Singleton patterns,
            // you should ensure that instances of the script that belong to the playing world and instances
            // that don't will not accidentally affect each other through those variables or Singletons.

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

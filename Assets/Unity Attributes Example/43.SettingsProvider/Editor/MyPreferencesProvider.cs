using System.IO;
using System.Linq;
using UnityEditor;

namespace LGamekit {

    class MyPreferencesProvider : SettingsProvider {

        public MyPreferencesProvider(string path, SettingsScope scope)
            : base(path, scope) { }

        [SettingsProvider]
        public static SettingsProvider CreateMyCutomSettingsOnPreferencesWindowProvider() {
            return new MyPreferencesProvider("MyPreferences", SettingsScope.User);
        }

        public override void OnGUI(string searchContext) {
            base.OnGUI(searchContext);

            EditorGUILayout.LabelField("This is my preferences.");

        }
    }
}

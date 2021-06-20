using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

using System;
using System.Reflection;

using System.Linq;
using System.Text;

namespace UnityAttributesExample {

    // https://champview.wordpress.com/2014/12/12/a-summary-of-unity-attributes/

    public class UnityAttributeUtility {

        public static Type[] GetUnityEngineAtributes() {
            return GetAttributesFromNamespace(typeof(MonoBehaviour));
        }

        public static Type[] GetUnityEditorAtributes() {
            return GetAttributesFromNamespace(typeof(CustomEditor));
        }

        public static Type[] GetAttributesFromNamespace(Type namespaceType) {
            return namespaceType.Assembly.GetExportedTypes().Where(t => IncludeType(t)).ToArray();
        }

        static bool IncludeType(Type t) {
            return t.IsPublic && !t.IsDefined(typeof(ObsoleteAttribute)) && typeof(Attribute).IsAssignableFrom(t);
        }

        static string ConverTo(Type[] types) {
            StringBuilder sb = new StringBuilder();
            foreach (var t in types) {
                sb.AppendLine(t.FullName);
            }
            return sb.ToString();
        }

        [@MenuItem("Assets/Unity-Attributes-Example/Log UnityEngine Attributes", false, 7025)]
        static void LogUnityEngineAttributes() {
            GUIUtility.systemCopyBuffer = ConverTo(GetUnityEngineAtributes());
            Debug.LogWarning(GUIUtility.systemCopyBuffer);
        }

        [@MenuItem("Assets/Unity-Attributes-Example/Log UnityEditor Attributes", false, 7026)]
        static void LogUnityEditorAttributes() {
            GUIUtility.systemCopyBuffer = ConverTo(GetUnityEditorAtributes());
            Debug.LogWarning(GUIUtility.systemCopyBuffer);
        }

        [@MenuItem("Assets/Unity-Attributes-Example/CopyAssetPath20", false, -1)]
        static void CopyAssetPath20() {
            if (Selection.activeObject == null) {
                return;
            }
            GUIUtility.systemCopyBuffer = AssetDatabase.GetAssetPath(Selection.activeObject).Replace(" ", "%20");
            Debug.LogWarning(GUIUtility.systemCopyBuffer);
        }

        /*

        UnityEngine Attributes:

        JetBrains.Annotations.CanBeNullAttribute
        JetBrains.Annotations.NotNullAttribute
        JetBrains.Annotations.ItemNotNullAttribute
        JetBrains.Annotations.ItemCanBeNullAttribute
        JetBrains.Annotations.StringFormatMethodAttribute
        JetBrains.Annotations.ValueProviderAttribute
        JetBrains.Annotations.InvokerParameterNameAttribute
        JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute
        JetBrains.Annotations.ContractAnnotationAttribute
        JetBrains.Annotations.LocalizationRequiredAttribute
        JetBrains.Annotations.CannotApplyEqualityOperatorAttribute
        JetBrains.Annotations.BaseTypeRequiredAttribute
        JetBrains.Annotations.UsedImplicitlyAttribute
        JetBrains.Annotations.MeansImplicitUseAttribute
        JetBrains.Annotations.PublicAPIAttribute
        JetBrains.Annotations.InstantHandleAttribute
        JetBrains.Annotations.PureAttribute
        JetBrains.Annotations.MustUseReturnValueAttribute
        JetBrains.Annotations.ProvidesContextAttribute
        JetBrains.Annotations.PathReferenceAttribute
        JetBrains.Annotations.SourceTemplateAttribute
        JetBrains.Annotations.MacroAttribute
        JetBrains.Annotations.CollectionAccessAttribute
        JetBrains.Annotations.AssertionMethodAttribute
        JetBrains.Annotations.AssertionConditionAttribute
        JetBrains.Annotations.LinqTunnelAttribute
        JetBrains.Annotations.NoEnumerationAttribute
        JetBrains.Annotations.RegexPatternAttribute
        JetBrains.Annotations.NoReorderAttribute
        UnityEngineInternal.TypeInferenceRuleAttribute
        Unity.Jobs.LowLevel.Unsafe.JobProducerTypeAttribute
        Unity.Collections.ReadOnlyAttribute
        Unity.Collections.WriteOnlyAttribute
        Unity.Collections.DeallocateOnJobCompletionAttribute
        Unity.Collections.NativeFixedLengthAttribute
        Unity.Collections.NativeMatchesParallelForLengthAttribute
        Unity.Collections.NativeDisableParallelForRestrictionAttribute
        Unity.Collections.LowLevel.Unsafe.NativeContainerAttribute
        Unity.Collections.LowLevel.Unsafe.NativeContainerIsReadOnlyAttribute
        Unity.Collections.LowLevel.Unsafe.NativeContainerIsAtomicWriteOnlyAttribute
        Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsMinMaxWriteRestrictionAttribute
        Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeallocateOnJobCompletionAttribute
        Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeferredConvertListToArray
        Unity.Collections.LowLevel.Unsafe.NativeSetThreadIndexAttribute
        Unity.Collections.LowLevel.Unsafe.WriteAccessRequiredAttribute
        Unity.Collections.LowLevel.Unsafe.NativeDisableUnsafePtrRestrictionAttribute
        Unity.Collections.LowLevel.Unsafe.NativeDisableContainerSafetyRestrictionAttribute
        Unity.Collections.LowLevel.Unsafe.NativeSetClassTypeToNullOnScheduleAttribute
        Unity.Burst.BurstDiscardAttribute
        AOT.MonoPInvokeCallbackAttribute
        UnityEngine.RuntimeInitializeOnLoadMethodAttribute
        UnityEngine.ExcludeFromObjectFactoryAttribute
        UnityEngine.DisallowMultipleComponent
        UnityEngine.RequireComponent
        UnityEngine.AddComponentMenu
        UnityEngine.CreateAssetMenuAttribute
        UnityEngine.ContextMenu
        UnityEngine.ExecuteInEditMode
        UnityEngine.ExecuteAlways
        UnityEngine.HideInInspector
        UnityEngine.HelpURLAttribute
        UnityEngine.DefaultExecutionOrder
        UnityEngine.AssemblyIsEditorAssembly
        UnityEngine.ExcludeFromPresetAttribute
        UnityEngine.SelectionBaseAttribute
        UnityEngine.UnityAPICompatibilityVersionAttribute
        UnityEngine.SerializeField
        UnityEngine.SerializeReference
        UnityEngine.PreferBinarySerialization
        UnityEngine.IconAttribute
        UnityEngine.PropertyAttribute
        UnityEngine.ContextMenuItemAttribute
        UnityEngine.InspectorNameAttribute
        UnityEngine.TooltipAttribute
        UnityEngine.SpaceAttribute
        UnityEngine.HeaderAttribute
        UnityEngine.RangeAttribute
        UnityEngine.MinAttribute
        UnityEngine.MultilineAttribute
        UnityEngine.TextAreaAttribute
        UnityEngine.ColorUsageAttribute
        UnityEngine.GradientUsageAttribute
        UnityEngine.DelayedAttribute
        UnityEngine.NonReorderableAttribute
        UnityEngine.ImageEffectTransformsToLDR
        UnityEngine.ImageEffectAllowedInSceneView
        UnityEngine.ImageEffectOpaque
        UnityEngine.ImageEffectAfterScale
        UnityEngine.ImageEffectUsesCommandBuffer
        UnityEngine.BeforeRenderOrderAttribute
        UnityEngine.Search.SearchContextAttribute
        UnityEngine.Internal.DefaultValueAttribute
        UnityEngine.Internal.ExcludeFromDocsAttribute
        UnityEngine.Serialization.FormerlySerializedAsAttribute
        UnityEngine.Lumin.UsesLuminPlatformLevelAttribute
        UnityEngine.Lumin.UsesLuminPrivilegeAttribute
        UnityEngine.Scripting.AlwaysLinkAssemblyAttribute
        UnityEngine.Scripting.RequireDerivedAttribute
        UnityEngine.Scripting.RequiredInterfaceAttribute
        UnityEngine.Scripting.RequireAttributeUsagesAttribute
        UnityEngine.Scripting.PreserveAttribute
        UnityEngine.Scripting.RequireImplementorsAttribute
        UnityEngine.Scripting.RequiredMemberAttribute
        UnityEngine.Scripting.APIUpdating.MovedFromAttribute
        UnityEngine.TestTools.ExcludeFromCoverageAttribute

         */

        /*

        UnityEditor Attributes:

        TreeEditor.TreeAttribute
        Unity.Profiling.Editor.ProfilerModuleMetadataAttribute
        UnityEditor.DrawGizmo
        UnityEditor.InitializeOnLoadAttribute
        UnityEditor.InitializeOnLoadMethodAttribute
        UnityEditor.InitializeOnEnterPlayModeAttribute
        UnityEditor.EditorWindowTitleAttribute
        UnityEditor.FilePathAttribute
        UnityEditor.MenuItem
        UnityEditor.CallbackOrderAttribute
        UnityEditor.SettingsProviderAttribute
        UnityEditor.SettingsProviderGroupAttribute
        UnityEditor.CustomPropertyDrawer
        UnityEditor.CustomEditor
        UnityEditor.CustomPreviewAttribute
        UnityEditor.CustomEditorForRenderPipelineAttribute
        UnityEditor.CanEditMultipleObjects
        UnityEditor.RootEditorAttribute
        UnityEditor.LightingExplorerExtensionAttribute
        UnityEditor.CommandHandlerAttribute
        UnityEditor.LocalizationAttribute
        UnityEditor.MPE.RoleProviderAttribute
        UnityEditor.ShortcutManagement.ShortcutBaseAttribute
        UnityEditor.ShortcutManagement.ShortcutAttribute
        UnityEditor.ShortcutManagement.ClutchShortcutAttribute
        UnityEditor.Toolbars.EditorToolbarElementAttribute
        UnityEditor.EditorTools.ToolAttribute
        UnityEditor.EditorTools.EditorToolAttribute
        UnityEditor.EditorTools.EditorToolContextAttribute
        UnityEditor.VersionControl.VersionControlAttribute
        UnityEditor.SearchService.SceneSearchEngineAttribute
        UnityEditor.SearchService.ProjectSearchEngineAttribute
        UnityEditor.SearchService.ObjectSelectorEngineAttribute
        UnityEditor.Overlays.OverlayAttribute
        UnityEditor.Callbacks.PostProcessBuildAttribute
        UnityEditor.Callbacks.PostProcessSceneAttribute
        UnityEditor.Callbacks.DidReloadScripts
        UnityEditor.Callbacks.OnOpenAssetAttribute
        UnityEditor.Rendering.ScriptableRenderPipelineExtensionAttribute
        UnityEditor.AssetImporters.CollectImportedDependenciesAttribute
        UnityEditor.AssetImporters.ScriptedImporterAttribute

         */
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

using System;
using System.Reflection;

using System.Linq;
using System.Text;

namespace LGamekit {

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

        [@MenuItem("Assets/Log UnityEngine Attributes", false, 7025)]
        static void LogUnityEngineAttributes() {
            GUIUtility.systemCopyBuffer = ConverTo(GetUnityEngineAtributes());
            Debug.LogWarning(GUIUtility.systemCopyBuffer);
        }

        [@MenuItem("Assets/Log UnityEditor Attributes", false, 7026)]
        static void LogUnityEditorAttribute() {
            GUIUtility.systemCopyBuffer = ConverTo(GetUnityEditorAtributes());
            Debug.LogWarning(GUIUtility.systemCopyBuffer);
        }

        /*

        UnityEngine Atributes:

        AOT.MonoPInvokeCallbackAttribute
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
        JetBrains.Annotations.CanBeNullAttribute
        JetBrains.Annotations.NotNullAttribute
        JetBrains.Annotations.StringFormatMethodAttribute
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
        JetBrains.Annotations.PathReferenceAttribute
        JetBrains.Annotations.NoEnumerationAttribute
        JetBrains.Annotations.AssertionMethodAttribute
        JetBrains.Annotations.LinqTunnelAttribute
        UnityEngine.BeforeRenderOrderAttribute
        UnityEngine.ImageEffectTransformsToLDR
        UnityEngine.ImageEffectAllowedInSceneView
        UnityEngine.ImageEffectOpaque
        UnityEngine.ImageEffectAfterScale
        UnityEngine.ImageEffectUsesCommandBuffer
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
        UnityEngine.ExcludeFromObjectFactoryAttribute
        UnityEngine.RuntimeInitializeOnLoadMethodAttribute
        UnityEngine.SelectionBaseAttribute
        UnityEngine.UnityAPICompatibilityVersionAttribute
        UnityEngine.SerializeField
        UnityEngine.SerializeReference
        UnityEngine.PreferBinarySerialization
        UnityEngine.Serialization.FormerlySerializedAsAttribute
        UnityEngine.Scripting.AlwaysLinkAssemblyAttribute
        UnityEngine.Scripting.PreserveAttribute
        UnityEngine.Scripting.APIUpdating.MovedFromAttribute
        UnityEngine.Lumin.UsesLuminPlatformLevelAttribute
        UnityEngine.Lumin.UsesLuminPrivilegeAttribute
        UnityEngine.Internal.DefaultValueAttribute
        UnityEngine.Internal.ExcludeFromDocsAttribute
        UnityEngine.TestTools.ExcludeFromCoverageAttribute

         */

        /*

        UnityEditor Atrributes:

        TreeEditor.TreeAttribute
        UnityEditor.CallbackOrderAttribute
        UnityEditor.DrawGizmo
        UnityEditor.InitializeOnLoadAttribute
        UnityEditor.InitializeOnLoadMethodAttribute
        UnityEditor.MenuItem
        UnityEditor.CommandHandlerAttribute
        UnityEditor.CustomEditor
        UnityEditor.CustomPreviewAttribute
        UnityEditor.CustomEditorForRenderPipelineAttribute
        UnityEditor.CanEditMultipleObjects
        UnityEditor.RootEditorAttribute
        UnityEditor.LightingExplorerExtensionAttribute
        UnityEditor.CustomPropertyDrawer
        UnityEditor.SettingsProviderAttribute
        UnityEditor.SettingsProviderGroupAttribute
        UnityEditor.ShortcutManagement.ShortcutBaseAttribute
        UnityEditor.ShortcutManagement.ShortcutAttribute
        UnityEditor.ShortcutManagement.ClutchShortcutAttribute
        UnityEditor.Localization.Editor.LocalizationAttribute
        UnityEditor.EditorTools.EditorToolAttribute
        UnityEditor.UIElements.UxmlNamespacePrefixAttribute
        UnityEditor.Callbacks.PostProcessBuildAttribute
        UnityEditor.Callbacks.PostProcessSceneAttribute
        UnityEditor.Callbacks.DidReloadScripts
        UnityEditor.Callbacks.OnOpenAssetAttribute
        UnityEditor.Experimental.GraphView.TypeAdapter
        UnityEditor.Experimental.AssetImporters.CollectImportedDependenciesAttribute
        UnityEditor.Experimental.AssetImporters.ScriptedImporterAttribute

         */
    }

}

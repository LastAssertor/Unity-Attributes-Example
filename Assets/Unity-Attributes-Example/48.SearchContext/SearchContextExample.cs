using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Search;

using Object = UnityEngine.Object;

namespace UnityAttributesExample {

    /// <summary>
    /// https://docs.unity.cn/2021.2/Documentation/ScriptReference/Search.SearchContextAttribute.html
    /// https://docs.unity.cn/2021.2/Documentation/ScriptReference/Search.SearchContextAttribute-ctor.html
    /// </summary>

    public class SearchContextExample : MonoBehaviour {

        const string assetProviders = "adb;asset";
        const string objectProviders = "adb,asset,scene,expression";

        //[SearchContext("", "adb", SearchViewFlags.ListView)] public MonoScript myProjectScript;
        //[SearchContext("", "adb", SearchViewFlags.Packages | SearchViewFlags.CompactView)] public MonoScript myPackageScript;


        [SearchContext("", "adb", SearchViewFlags.ListView)]
        public Object myProjectScript;
        [SearchContext("", "adb", SearchViewFlags.Packages | SearchViewFlags.CompactView)]
        public Object myPackageScript;

        [SearchContext("t:texture", assetProviders, SearchViewFlags.GridView)]
        public Texture myTexture;
        [SearchContext("t:texture", "adb", SearchViewFlags.OpenInspectorPreview)]
        public Texture myTextureWithInspector;
        [SearchContext("Assets non_mobile", SearchViewFlags.Centered)]
        public Object myAnyObject;
        [SearchContext("Assets non_mobile", SearchViewFlags.Debug)]
        public Object myDebugObject;
        [SearchContext("t:mesh is:nested mesh", "asset")]
        public Object assetMesh;
        [SearchContext("h:cube", objectProviders)]
        public MeshFilter sceneMesh;
        [SearchContext("shader:standard", assetProviders, SearchViewFlags.HideSearchBar)]
        public Material materialNoSearchBar;
        [SearchContext("select{p:t:material, @label, @size}", objectProviders, SearchViewFlags.TableView)]
        public Material selectMaterial;
        [SearchContext("Assets/Queries/textures.asset", assetProviders)]
        public Texture searchQueryPathTexture;
        [SearchContext("3c7f5dff3fb5d724688dfcecfb131b2a", assetProviders)]
        public Texture searchQueryGuidTexture;
        [SearchContext("Assets non_mobile", SearchViewFlags.EnableSearchQuery)]
        public Object myObjectWithSearchQueryEnabled;
        [SearchContext("Assets non_mobile", SearchViewFlags.DisableInspectorPreview)]
        public Object myObjectWithInspectorDisabled;

        public Object noSearchContextObj;

    }

}
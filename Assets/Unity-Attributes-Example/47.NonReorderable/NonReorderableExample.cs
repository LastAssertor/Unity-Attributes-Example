using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class NonReorderableExample : MonoBehaviour {

        /// <summary>
        /// 不可排序
        /// </summary>
        [NonReorderable]
        public List<int> nonReorderableList = new List<int> { 1, 4, 2, 99 };
        /// <summary>
        /// 可排序
        /// </summary>
        public List<string> reorderableList = new List<string> { "哈哈", "哈", "哈哈哈哈" };


    }

}
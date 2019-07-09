using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class TextAreaExample : MonoBehaviour {

        // Attribute to make a string be edited with a height-flexible and scrollable text area.

        // You can specify the minimum and maximum lines for the TextArea,
        // and the field will expand according to the size of the text.
        // A scrollbar will appear if the text is bigger than the area available.

        // Note: The maximum lines refers to the maximum size of the TextArea.
        // There is no maximum to the number of lines entered by the user.

        [TextArea]
        public string MyTextArea;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LGamekit {

    public class SerializeFieldExample : MonoBehaviour {

        // This field gets serialized because it is public.
        public string firstName = "John";

        // This field does not get serialized because it is private.
        private int age = 40;

        // Force Unity to serialize a private field.

        // When Unity serializes your scripts, it will only serialize public fields.
        // If in addition to that you also want Unity to serialize one of your private fields you can add the SerializeField attribute to the field.

        // Unity will serialize all your script components, reload the new assemblies,
        // and recreate your script components from the serialized verions.
        // This serialization does not happen with .NET's serialization functionality, but with an internal Unity one.

        // The serialization system used can do the following:

        // - CAN serialize public nonstatic fields (of serializable types)
        // - CAN serialize nonpublic nonstatic fields marked with the SerializeField attribute.
        // - CANNOT serialize static fields.
        // - CANNOT serialize properties.

        // Your field will only serialize if it is of a type that Unity can serialize:

        // Serializable types are:

        // - All classes inheriting from UnityEngine.Object, for example GameObject, Component, MonoBehaviour, Texture2D, AnimationClip.
        // - All basic data types like int, string, float, bool.
        // - Some built-in types like Vector2, Vector3, Vector4, Quaternion, Matrix4x4, Color, Rect, LayerMask.
        // - Arrays of a serializable type
        // - List of a serializable type
        // - Enums
        // - Structs

        // Note: if you put one element in a list (or array) twice, when the list gets serialized,
        // you'll get two copies of that element, instead of one copy being in the new list twice.

        // Hint: Unity won't serialize Dictionary, however you could store a List<> for keys and a List<> for values,
        // and sew them up in a non serialized dictionary on Awake().
        // This doesn't solve the problem of when you want to modify the dictionary and have it "saved" back,
        // but it is a handy trick in a lot of other cases.

        // This field gets serialized even though it is private
        // because it has the SerializeField attribute applied.
        [SerializeField]
        private bool hasHealthPotion = true;

        void Start() {
            if (hasHealthPotion)
                Debug.Log("Person's first name: " + firstName + " Person's age: " + age);
        }

    }

}

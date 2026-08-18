
using System;
using System.Collections.Generic;
using UnityEngine;


// Based on this style guide. Some conventions are different though.
// https://github.com/thomasjacobsen-unity/Unity-Code-Style-Guide/blob/master/StyleExample.cs

namespace StyleGuideExample 
{
    // ENUMS:
    // | PascalCase for enum names and values
    // | Avoid placing enums outside of classes and making them global unless neccessary 
    // | Trailling element should have a comma
    public enum Direction
    {
        North,
        East,
        South,
        West,
    }


    // INTERFACES:
    // | Prefix interface names with a capital I
    // | Should be named an adjective that describes functionality 
    public interface ICollectable
    {
        bool Collect();
    }

    // CLASSES and STRUCTS:
    // | Use PascalCase
    // | Named with noun or noun phrases
    // | One MonoBhavior class per file. Monobehavior name must match filename
    // | Non-MonoBehavior helper classes may be included in the same file
    // | Add RequireComponentAttribute for component dependencies

    [RequireComponent(typeof(Transform))]
    public class ExampleMonoBehavior : MonoBehaviour
    {
        // FIELDS: 
        // | Limit abbreviation. Prioritize readablity over brevity
        // | camelCase for all non static or const fields 
        // | Do not use type prefixes (_, m_, s_, k_, etc..)
        // | Mark as readonly if it is not reassigned at runtime or exposed in the inspector
        // | Omit the "private" access modifier, and other implicit redundnacies 
        // | Booleans are questions and should be prefixed by a verb
        // | float values should have the "f" suffix


        int examplePrivateField = 1;
        readonly float floatExample = 5f;

        // Use the [SerializeField] attribute to expose private field in the inspector 
        // Avoid using public fields solely for serialization
        [SerializeField] bool isDead;

        // Properties: 
        // | Preferzble to a public field
        // | PascalCase for all properties
        // | Use expression-bodied properties if possible (i.e. member => expression)

        // Backing field
        int maxHealth;

        // Returns backing field
        public int MaxHealthReadonly => maxHealth;
        // Equivalent to:
        public int MaxHealth { get; private set; }


        // METHODS: 
        // | PascalCase for method name
        // | camelCase for parameters
        // | expression-body format for simple one-line methods that you know will not expand in complexity
        // | Avoid writing a method with too many parameters, pack into struct or class if needed
        // | In MonoBehavior classes, place life cycle methods ahead of custom methods
        // | Empty methods (for undefined overridden abstract methods) open and close braces {} on the same line


        void MethodFormatExample(GameObject objectParameter)
        {
            //LOCALS:
            // | locals should generally be placed above method logic
            // | create local variables instead of using "magic numbers" 
            // | you can use "var" if the type is obvious 

            var list = new List<float>();           // var here ok. type is clear
            var thing = AmbiguousReturnMethod();    // var here bad. its unclear   


            int amount = 100;

            DoSomething(100);                       //BAD, magic number
            DoSomething(amount);                    //GOOD, local variable


            //NESTING: 
            // | Avoid deep nesting
            // | Opening braces should be written on a new line.
            // | Prefer guard clauses over nested null checks
            // | Guard claused may omit braces and have return on the same line

            if (objectParameter == null) return;    //GOOD

            //... do stuff

            if (objectParameter != null)            //BAD
            {
                    //... do stuff
            }
        }


        float AmbiguousReturnMethod() => 0f;
        public void DoSomething(int amount)
        {
            // do something...
        }
    }


}

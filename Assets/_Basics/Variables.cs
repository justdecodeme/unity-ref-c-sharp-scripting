using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    void Start()
    {
        /* accessModifier dataType UniqueName = value; */

        string _string = "Rakko";
        int _int = 13;
        bool _bool = true;
        float _float = 13.05f;
        /* Inferred declarations >  C# can infer a variable's type from its assigned value */
        var age = 32;
        // vector2, vecor3, ref, arr, list...

        Debug.Log("string: " + _string);
        Debug.Log("int: " + _int);
        Debug.Log("bool: " + _bool);
        Debug.Log("float: " + _float);
        Debug.Log("age: " + age);
    }

}

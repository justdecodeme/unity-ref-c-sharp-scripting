using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    void Start()
    {
        string name =  "  C # Scripting";

        /* properties */
        Debug.Log(name.Length);

        /* methods */
        Debug.Log(name.ToUpper());
        Debug.Log(name.ToLower());
        Debug.Log(name.Trim());
        Debug.Log(name.Replace("Scripting", "Programming"));
    }

}

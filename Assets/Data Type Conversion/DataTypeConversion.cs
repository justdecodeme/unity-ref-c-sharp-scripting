using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeConversion : MonoBehaviour
{
    void Start()
    {
        /* sting to int */
        string a = "32" ;
        int b = int.Parse(a);
        Debug.Log(b); // 32

        /* string to float */
        string c = "10.5";
        float d = float.Parse(c);
        Debug.Log(d); // 10.5

        /* int to string */
        int e = 100;
        string f = e.ToString();
        Debug.Log(f); // "100"

        /* int to float */
        int g = 12;
        float h =  3.4f + (float)g;
        Debug.Log(h); // 15.4

        /* float to int */
        float i = 10.5f;
        int j = 15 + (int)i;
        Debug.Log(j); // 25
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    void Start()
    {
        string[] family = new string[5];
        family[0] = "Homer";
        family[1] = "Marge";
        family[2] = "Bart";
        family[3] = "Lisa";
        family[4] = "Maggie";        

        Debug.Log(family);
        Debug.Log(family[1]);
    }
}

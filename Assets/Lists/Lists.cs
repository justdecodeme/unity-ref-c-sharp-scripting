using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    void Start()
    {
        List<string> family = new List<string>();
        family.Add("Homer");
        family.Add("Marge");
        family.Add("Bart");
        family.Add("Lisa");
        family.Add("Maggie");
        Debug.Log(family[0]);
        Debug.Log(family[2]);
        Debug.Log("Family Size = " + family.Count);        
    }
}

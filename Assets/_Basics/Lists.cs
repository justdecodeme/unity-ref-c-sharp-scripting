using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    void Start()
    {
        /* List<elementType> UniqueName = new List<elementType>(); */
        /* List<elementType> UniqueName = new List<elementType>() { _, _, _, ...} */

        List<string> family = new List<string>();

        /* get */
        // Debug.Log(family[0]);

        /* set */
        // family[0] = "Member1";

        /* add */
        family.Add("Member2");
        family.Insert(1, "Member3");
        family.Add("Member4");
        family.Add("Member5");

        /* remove */
        family.RemoveAt(0);
        family.Remove("Member5");

        /* check */

        /* length */
        Debug.Log("Family Size = " + family.Count);

        /* loop */
        for (int i = 0; i < family.Count; i++)
        {
            Debug.LogFormat("Member {0}: {1}", i, family[i]);
        }
        foreach (string member in family)
        {
            Debug.Log(member);
        }

        List<string> family2 = new List<string>() { "Member1", "Member2" };
        Debug.Log("Family2 Size = " + family2.Count);
    }
}

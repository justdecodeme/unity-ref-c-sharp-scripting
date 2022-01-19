using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    void Start()
    {
        /* Dictionary<keyType, valueType> UniqueName = new Dictionary<keyType, valueType>(); */
        /* Dictionary<keyType, valueType> UniqueName = new Dictionary<keyType, valueType>() { {k1, v1}, {k2, v2}}; */

        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "Aspirin", 1 }
        };

        /* get */
        Debug.Log(ItemInventory["Potion"]);

        /* set */
        ItemInventory["Potion"] = 10;

        /* add */
        ItemInventory.Add("Throwing Knife", 3);

        /* remove */
        ItemInventory.Remove("Antidote");

        /* check */
        Debug.Log(ItemInventory.ContainsKey("Aspirin"));

        /* length */
        Debug.LogFormat("Items: {0}", ItemInventory.Count);

        /* loops */
        foreach (KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }
    }
}

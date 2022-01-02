using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObject : MonoBehaviour
{
    public GameObject target1;
    private GameObject target2;
    private GameObject target3;

    void Start()
    {
        /* target1 is set in the editor */

        /* target2 is set based on the GameObject name */
        target2 = GameObject.Find("Enemy");

        // target3 is set based on the GameObject tag
        target3 = GameObject.FindWithTag("Player");
        
        // make the gameObjects inactive
        target1.SetActive(false);
        target2.SetActive(false);
        target3. SetActive(false);
    }

}

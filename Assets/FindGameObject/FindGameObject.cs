using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObject : MonoBehaviour
{
    public GameObject go1;

    private GameObject go2;
    private GameObject go3;
    private GameObject go4;
    private GameObject[] go5;

    void Start()
    {
        /* go1 is set in the EDITOR */

        /* go2 is set based on the GameObject NAME */
        go2 = GameObject.Find("Enemy");
        // Debug.Log(go2.transform.childCount); // not working
        go3 = GameObject.Find("Parent/Child");

        /* go3 is set based on the GameObject TAG */
        go4 = GameObject.FindWithTag("Player");
        go5 = GameObject.FindGameObjectsWithTag("Trap");

        /* ----------------- */



        /* ----------------- */

        /* make the gameObjects inactive */
        go1.SetActive(false);
        go2.SetActive(false);
        go3.SetActive(false);
        go4.SetActive(false);
        foreach (GameObject go in go5)
        {
            go.SetActive(false);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    private Transform trans;

    void Start()
    {
        trans = GetComponent<Transform>();

        /* both will work same */
        Debug.Log(trans.localPosition);
        Debug.Log(transform.localPosition);
    }
}

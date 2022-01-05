using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        GetComponentInChildren<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().useGravity = false;
    }
}

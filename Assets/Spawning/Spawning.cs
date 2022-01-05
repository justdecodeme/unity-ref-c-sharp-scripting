using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    void Start()
    {
        // transform.position.y += 1; // not working????
        transform.Translate(1, 0, 0);
    }

}

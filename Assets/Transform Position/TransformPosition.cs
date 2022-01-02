using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public GameObject gameObject;

    void Start()
    {
        // gameObject.transform.position.y += 1; // not working????
        gameObject.transform.Translate(1,0,0);
    }

}

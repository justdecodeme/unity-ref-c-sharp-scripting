using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLoop : MonoBehaviour
{
    /* run on when script enabled */
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }


    /* run on when script disabled */
    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}

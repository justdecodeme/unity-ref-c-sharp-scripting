using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* call function ONCE after 2 seconds */
        Invoke("_Invoke", 2f);

        /* call function after 3 seconds then repeat each second */
        InvokeRepeating("_InvokeRepeating", 3f, 1f);

    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            CancelInvoke("_InvokeRepeating");
        }
    }

    void _Invoke() {
        Debug.Log("_Invoke");
    }
    void _InvokeRepeating() {
        Debug.Log("_InvokeRepeating");
    }
}

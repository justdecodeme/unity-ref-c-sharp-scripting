using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    void Update()
    {
        /* 0 - LMB | 1 - RMB | 2 - MMB */
        if(Input.GetMouseButtonDown(0)) {
            Debug.Log("LMB down.");
        }
        if(Input.GetMouseButton(0)) {
            Debug.Log("LMB pressed...");
        }
        if(Input.GetMouseButtonUp(0)) {
            Debug.Log("LMB up.");
        }

        if(Input.GetMouseButtonDown(1)) {
            Debug.Log(Input.mousePosition);
            Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            Debug.Log("--------------");
        }


    }
}

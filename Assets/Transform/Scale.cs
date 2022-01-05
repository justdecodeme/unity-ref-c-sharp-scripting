using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float scaleSpeed = 1f;

    void Update()
    {
        // transform.localScale += new Vector3(0f, scaleSpeed * Time.deltaTime, 0f);
        transform.localScale += transform.up * scaleSpeed * Time.deltaTime;
    }

}

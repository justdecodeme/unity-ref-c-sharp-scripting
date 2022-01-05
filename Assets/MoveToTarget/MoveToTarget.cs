using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    public float moveSpeed = 10f;

    void Update()
    {
        float dist = Vector3.Distance(targetTransform.position, transform.position);
        if (dist > .001f)
        {
            Vector3 moveDir = (targetTransform.position - transform.position).normalized;
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        }

        print("Distance to other: " + dist);
    }

}

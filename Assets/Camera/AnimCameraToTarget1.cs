using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCameraToTarget1 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _rotSpeed = 30f;

    public List<Transform> camPositionList = new List<Transform>();  //asign all transforms in inspector, including the initial position
    private int clickCounter = 0;
    private int camPositionListCount = 0;
    private bool clicked;

    void Start() {
        camPositionListCount = camPositionList.Count;
    }

    void Update () {
    
        if (Input.GetMouseButtonDown(0)) // this will rgister a click anywhere on the screen, you need to ray cast on your button
        {
            clicked = true;
            
            /* ensures that number of clicks do not exceed the number of transforms in you list else you might get an Out of Range error */
            clickCounter = Mathf.Clamp(clickCounter, 0, camPositionList.Count-1);

            clickCounter++;

            if (clickCounter == camPositionListCount) clickCounter = 0;
        }

        if(clicked) {
            MoveToNextTarget();
        }
    }

    private void MoveToNextTarget() {
        Vector3 camTargetPos = camPositionList[clickCounter].position;

        if (transform.position == camTargetPos) clicked = false;

        transform.position = Vector3.MoveTowards(transform.position, camTargetPos, _speed * Time.deltaTime);

        /* sudden rotation */
        // transform.LookAt(camTargetPos);

        /* smooth rotation */
        // Quaternion lookAtTarget = Quaternion.LookRotation(camTargetPos - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, camPositionList[clickCounter].rotation, _rotSpeed * Time.deltaTime);

        Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
        // transform.Translate(0, 0, speed * Time.deltaTime);            
    }
}

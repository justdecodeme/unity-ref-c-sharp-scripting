using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    /* the speed, in units per second */
    public float MoveSpeed = 1f;

    void Update()
    {
        /* not work */
        // transform.position.z = 5f;

        /* move 3m/frame */
        // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + MoveSpeed);
        // transform.position += new Vector3(0f, 0f, MoveSpeed);

        /* moves 3m/s */
        // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (MoveSpeed * Time.deltaTime));
        // transform.position += new Vector3(0f, 0f, MoveSpeed * Time.deltaTime);

        /* move the object in world space along the world z axis */
        // transform.Translate(0f, 0f, (MoveSpeed * Time.deltaTime), Space.World);
        // transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime, Space.World);

        /* move the object in local space along the "forward" z axis */
        transform.Translate(0f, 0f, (MoveSpeed * Time.deltaTime), Space.Self);
    }

}

// NEW METHOD USING FORCE

    // private float speed = 10.0f;
    // private Rigidbody rb;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     float H = Input.GetAxis("Horizontal");
    //     float V = Input.GetAxis("Vertical");

    //     rb.AddForce(Vector3.forward * speed * V);
    //     rb.AddForce(Vector3.right * speed * H);
    // }
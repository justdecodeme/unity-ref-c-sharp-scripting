using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public float moveSpeed = 20f; 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space key down.");
        }
        if(Input.GetKey(KeyCode.Space)) {
            Debug.Log("Space key pressed...");
        }
        if(Input.GetKeyUp(KeyCode.Space)) {
            Debug.Log("Space key up.");
        }

        /* defined in Edit > Project Settings... > Input Manager */
        if(Input.GetButtonDown("Cancel")) {
            Debug.Log("Esc key down.");
        }
        if(Input.GetButton("Cancel")) {
            Debug.Log("Esc key pressed...");
        }
        if(Input.GetButtonUp("Cancel")) {
            Debug.Log("Esc key up.");
        }

        /* smooth movement */
        // float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        // float y = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        /* sudden stop */
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(x, y, 0f);
    }
}
